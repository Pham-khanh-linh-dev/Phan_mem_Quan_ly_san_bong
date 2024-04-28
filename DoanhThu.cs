using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM
{
    internal class DoanhThu
    {
        string id, ql_id;
        int thu, chi;
        string date;
        public DoanhThu(string id, int thu, int chi, string ql, string date) {
            this.id = id;
            this.ql_id = ql;
            this.thu = thu;
            this.chi = chi;
            // Chuyển đổi chuỗi thành đối tượng DateTime
            DateTime datetime = DateTime.Parse(date);

            // Lấy ngày của datetime
            string dateWithoutTime = datetime.ToString("dd/MM/yyyy");
            this.date = dateWithoutTime;
        }
        public string getQl_ID() { return ql_id; }
        public int getChi() { return chi; }
        public int getThu() { return thu; }
        public string getId() { return id; }
        public string getDate() { return date; }

        public void setName(string id) { this.id = id; }
        public void setGiamua(int thu) { this.thu = thu; }
        public void setGiaban(int chi) { this.chi = chi; }
        public void setId(string ql_id) { this.ql_id = ql_id; }
        public void setDate(string date) { this.date = date; }

    }
}
