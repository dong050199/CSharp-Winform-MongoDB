using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace MongoTest
{
    public class MongoDB_Config
    {
        public string ConnectionString;
        public string Database;
        public string Collection;

        //
         public class Mydata
        {
            public object Id { get; set; }
            public DateTime TimeStamp { get; set; }
            public string data1 { get; set; }
            public string data2 { get; set; }
            public string data3 { get; set; }
            public string data4 { get; set; }

        }
        public MongoDB_Config(string connectionstring,string database,string collection)
        {
            ConnectionString = connectionstring;
            Database = database;
            Collection = collection;
        }
        //hien thi du lieu dang Bindinglist hien thi ra datagridview dataGridview.DataSource = return this.
        public BindingList<Mydata> MongoQuery(DateTime fromdate, DateTime todate)
        {
            try
            {
                var client = new MongoClient(ConnectionString);
                var database = client.GetDatabase(Database);
                var collec = database.GetCollection<Mydata>(Collection);
                BindingList<Mydata> doclist = new BindingList<Mydata>();
                var min = fromdate;
                var max = todate;
                foreach (var deger in collec.Find(x => x.TimeStamp > min && x.TimeStamp < max).ToList())
                {
                    doclist.Add(deger);
                    Application.DoEvents();
                }
                return doclist;
            }
            catch
            {
                Console.WriteLine("Error when query database");
                return null;
            }
 
        }

        //Insert du lieu sang MongoDB duoi dang Bson document.
        public void MongoInsert(BsonDocument document)
        {
            try
            {
                var client = new MongoClient(ConnectionString);
                var database = client.GetDatabase(Database);
                var collec = database.GetCollection<BsonDocument>(Collection);
                collec.InsertOneAsync(document);
            }
            catch
            {
                Console.WriteLine("Error when insert Bson doc to MongoDB");
            }
        }

        //xoa du lieu theo ngay dươc dua vao
        public void MongoDelete(DateTime fromtime,string TimeStampKey)
        {
            try
            {
                var client = new MongoClient(ConnectionString);
                var database = client.GetDatabase(Database);
                var collec = database.GetCollection<BsonDocument>(Collection);
                var dataQuery = new BsonDocument
            {
                {TimeStampKey,new BsonDocument {
                    {"$lt",fromtime}
                } }
            };
                var resule = collec.DeleteMany(dataQuery);
            }
            catch
            {
                Console.WriteLine("Error when remove Bson doc from MongoDB");
            }

        }
    }
}
