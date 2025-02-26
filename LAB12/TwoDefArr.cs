using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12
{
    public class TwoDefArr
    {
        private double[,] array;
        private int rowCount;
        private int columnCount;
        
       
        public int RowCount {
            get { return rowCount; } 
            set { rowCount = value; }
        }

        public int ColumnCount {
            get { return columnCount; }
            set { columnCount = value; }
        }
        public double[,] Array { get { return array; } }
        public TwoDefArr(int rowCount, int columnCount) {
           
            this.rowCount = rowCount;
            this.columnCount = columnCount;
            array = new double[rowCount, columnCount];
        }
        public TwoDefArr rndArray(int rowCount, int columnCount) {
            TwoDefArr arr = new TwoDefArr(rowCount, columnCount);
            Random rnd = new Random();

            for(int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    arr.array[i, j] = Math.Round(rnd.NextDouble()*200-100, 2);
                }

            }
            return arr;
        }
        
    }
}
