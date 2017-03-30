/* 
 * Jeti Trading System v0
 * Date 2017-03
 * Author: Daniel Siliski
 *  */
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using IBApi;
using System.Data;
using System.Configuration;

namespace Jeti_v0{
    public class program{
        static DataTable p = new DataTable();
        static DataTable s = new DataTable();
        static Queue q = new Queue();
        static Dictionary<string, int> reqIds = new Dictionary<string, int>();
        struct rtbUpdateStruct{
            internal string ticker;
            internal long time;
            internal double close;}

        public static int Main(string[] args){

            // --------------------------------------------------------------------
            // Load ---------------------------------------------------------------
            //var activecontracts = GetActiveContracts();
            //var c = (from t in activecontracts
            //         where t.ActivityDate == DateTime.Today
            //         select t);
            var c = db.GetActiveContracts();

            Parallel.ForEach(c, (t) =>
                {
                    // Set up a repeating data import task
                    Task.Factory.StartNew(() => 
                    {
                        DataTable dt = new DataTable();                          
                        while (1 > 0)
                        {
                            //Console.WriteLine("Task Tester! ... " + t.IBFuturesLocalSymbol);
                            // //get some data and print to console (to be removed once more logic built)
                            //dt = GetPricesFromDB(t,20);
                            //foreach (DataRow r in dt.Rows)
                            //{
                            //    foreach (var i in r.ItemArray)
                            //    {
                            //        Console.WriteLine(i);

                            //    }
                            //}

                            // -------------------------------------------------------------------------------------
                            // calculate RSI
                            float neg = new float();
                            float pos = new float();
                            float num = new float();
                            float p_c = new float();
                            float n_c = new float();
                            dt = db.GetPricesFromDB(t, 10);

                            // get price changes from prices
                            if (dt.Rows.Count > 0)
                            {
                                dt = db.PriceChange(dt,0,0);

                                // RSI
                                //foreach (DataRow r in dt.Rows)
                                //{
                                //    num = (float)r["p_change"];
                                //    if (num > 0)
                                //    {
                                //        neg = neg + num;
                                //        n_c++;
                                //    }
                                //    else
                                //    {
                                //        pos = pos + num;
                                //        p_c++;
                                //    };
                                //}
                            }

                            // -------------------------------------------------------------------------------------
                            Console.WriteLine(dt);
                            Thread.Sleep(1000);
                        }
                    });
                }
            );

            // --------------------------------------------------------------------
            // Transform ----------------------------------------------------------


            // --------------------------------------------------------------------
            // Save ---------------------------------------------------------------


            // --------------------------------------------------------------------
            // Quit ---------------------------------------------------------------
            //Console.WriteLine("disconnecting... please press enter to close application.");
            Console.ReadLine();
            return 0;
        }





    }






}