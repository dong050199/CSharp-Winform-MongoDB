using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoTest
{
    public partial class Form1 : Form
    {

        public static string ConnectionString = "mongodb://localhost:27017";
        public static string Database = "DongTest";
        public static string Collection = "dong";
        public Form1()
        {
            InitializeComponent();
            dtpk_time_delete.Format = DateTimePickerFormat.Time;
            dtpk_time_delete.ShowUpDown = true;
            dtpk_time_from.Format = DateTimePickerFormat.Time;
            dtpk_time_from.ShowUpDown = true;
            dtpk_time_to.Format = DateTimePickerFormat.Time;
            dtpk_time_to.ShowUpDown = true;

        }

        MongoDB_Config mongoDB = new MongoDB_Config(ConnectionString, Database, Collection);
        
        private void bt_Insert_Click(object sender, EventArgs e)
        {
            var doc = new BsonDocument
            {
                {"TimeStamp",DateTime.Now},
                {"data1","dongvl" },
                {"data2","dong"},
                {"data3","dep"},
                {"data4","try"}
            };
            mongoDB.MongoInsert(doc);
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            var datetime = dtpk_date_delete.Value.Date + dtpk_time_delete.Value.TimeOfDay;
            mongoDB.MongoDelete(datetime,"TimeStamp");
        }

        private void bt_Query_Click(object sender, EventArgs e)
        {
            DateTime fromtime = dtpk_date_from.Value.Date + dtpk_time_from.Value.TimeOfDay;
            DateTime totime = dtpk_date_to.Value.Date + dtpk_time_to.Value.TimeOfDay;
            dataGridView1.DataSource = mongoDB.MongoQuery(fromtime, totime);
            Console.WriteLine(fromtime);
            Console.WriteLine(totime);
        }
    }
}
