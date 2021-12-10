using System;
using System.Windows.Forms;
using MongoDB.Bson;

namespace MongoTest
{
    public partial class Form1 : Form
    {
        //Khai báo thông tin của MongoDB bao gồm Connection string, database, collection
        public static string ConnectionString = "mongodb://localhost:27017";
        public static string Database = "DongTest";
        public static string Collection = "dong";
        public Form1()
        {
            InitializeComponent();
            //Cấu hình cài đặt cho các datetimepicker để lấy dữ liệu thời gian
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
            //Tạo BsonDocument để Insert vào MongoDB.
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
            //Xóa dữ liệu MongoDB từ thời gian được chọn trở về trước
            var datetime = dtpk_date_delete.Value.Date + dtpk_time_delete.Value.TimeOfDay;
            mongoDB.MongoDelete(datetime,"TimeStamp");
        }
        private void bt_Query_Click(object sender, EventArgs e)
        {
            //Tìm kiếm và hiển thị dữ liệu từ MongoDB về DataGridview.
            DateTime fromtime = dtpk_date_from.Value.Date + dtpk_time_from.Value.TimeOfDay;
            DateTime totime = dtpk_date_to.Value.Date + dtpk_time_to.Value.TimeOfDay;
            dataGridView1.DataSource = mongoDB.MongoQuery(fromtime, totime);
        }
    }
}
