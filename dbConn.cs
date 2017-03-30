using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using IBApi;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Net;
using System.Net.Sockets;

namespace Jeti_v0
{
    public class db
    {
        static public DataTable PriceChange(DataTable sourceDataTable, int periods, int frequencyInSeconds)
        {
            // converts a time series of prices into a time series of price changes (or returns)
            DataTable dt = sourceDataTable;
            int p = periods;
            int f = frequencyInSeconds;

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("p_change", typeof(double));
            double num = new double();



            for (int i = 1; i <= dt.Rows.Count - 1; i++)
            {
                num = (double)dt.Rows[i]["price"] - (double)dt.Rows[i - 1]["price"];
                dt2.Rows.Add(num);
                if (dt.Rows[0]["ticker"].ToString() == "CLJ7")
                {
                    Console.WriteLine("dt_i:   " + dt.Rows[i]["price"]);
                    Console.WriteLine("dt_i-1: " + dt.Rows[i - 1]["price"]);
                    Console.WriteLine("dt2   : " + dt2.Rows[i - 1]["p_change"]);
                    Console.WriteLine("--------------------");
                }
            }
            return dt2;
        }
        static public dynamic GetPriceData(ActiveContract t)
        {
            Console.WriteLine("--Getting Data For: " + t.IBFuturesLocalSymbol);
            using (var jetiDB = new JETIEntities())
            {
                return (from PriceCapture p in jetiDB.PriceCaptures
                        where p.Ticker == t.IBFuturesLocalSymbol
                        //&  p.IBTimestamp == DateTime.Today
                        select new { p.IBTimestamp, p.Ticker, p.Price }).ToList();
            }
        }
        static public DataTable GetPricesFromDB(ActiveContract t, int periods)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("time", typeof(DateTime));
            dt.Columns.Add("ticker", typeof(string));
            dt.Columns.Add("price", typeof(double));

            using (var jetiDB = new JETIEntities())
            {
                var q = (from PriceCapture p in jetiDB.PriceCaptures
                         where p.Ticker == t.IBFuturesLocalSymbol
                         orderby p.IBTimestamp descending
                         //&  p.IBTimestamp == DateTime.Today
                         select new { p.IBTimestamp, p.Ticker, p.Price }).Take(periods);

                foreach (var k in q)
                {
                    dt.Rows.Add(k.IBTimestamp, k.Ticker, k.Price);
                    //Console.WriteLine("");
                }
            }
            return dt;
        }
        static public List<ActiveContract> GetActiveContracts()
        {
            using (var jetiDB = new CF1())
            {
                return (from ActiveContract in jetiDB.ActiveContracts
                        where ActiveContract.ActivityDate == DateTime.Today
                        select ActiveContract).ToList();
            }
        }


    }
}
