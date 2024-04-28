using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM
{
    internal class DrinkItem
    {
        private string _name;
        private int giamua;
        private int giaban;
        private string id;
        public DrinkItem() { }

        public DrinkItem(string name, int giamua, int giaban, string id) { 
            this._name = name;
            this.giamua = giamua;
            this.giaban = giaban;
            this.id = id;
        }
        public string getName() {  return _name; }  
        public int getGiaMua() {  return giamua; }
        public int getGiaban() {  return giaban; }
        public string getId() { return id; }
        public void setName(string name) { _name = name; }
        public void setGiamua(int giaMua) {  giamua = giaMua; }
        public void setGiaban(int giaBan) { giaban = giaBan;  }
        public void setId(string id) { this.id = id;  }
    }
}
