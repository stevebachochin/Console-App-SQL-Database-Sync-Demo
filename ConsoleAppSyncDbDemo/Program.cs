using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;

namespace ConsoleAppSyncDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverConnectionString =
            @"data source=(localdb)\MSSQLLocalDB; 
            initial catalog=ServerDB; 
            integrated security=True;
            MultipleActiveResultSets=True;";
            string clientConnectionString =
            @"data source=(localdb)\MSSQLLocalDB; 
            initial catalog=ClientDB; 
            integrated security=True;
            MultipleActiveResultSets=True;";
            string tableName = "Products";
            DataSynchronizer.Synchronize(tableName, serverConnectionString,clientConnectionString);
            Console.WriteLine("Databases synchronized...");
            Console.Read();
        }



    }
}
