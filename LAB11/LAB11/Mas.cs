using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB11
{
    public class Mas
    {
        private List<double> matrix;
        private static Random rnd= new Random();    
        public List<double> Matrix { 
            set { matrix = value; }
            get { return matrix; }
        }
        public Mas() {
            matrix = new List<double>();
        }
        public void addToMas(double item) {
            matrix.Add(item);
        }
      
        public void removeMas(double item) { 
               matrix.Remove(item);
        }
       
        public Mas rndMas(int n)
        {
            Mas mas = new Mas();
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                mas.addToMas(Math.Round(rnd.NextDouble()*200-100,2));
            }
            return mas;
        }
        public double this[int index]
        {
            get { return matrix[index]; }
            set { matrix[index] = value; }
        }
        public Mas calcMas(Mas mas1, Mas mas2)
        {
            if (mas1.Matrix.Count != mas2.Matrix.Count)
            {
                return mas1;
            }
            if (mas1.Matrix.Count == 0 || mas2.Matrix.Count == 0)
            {
                return mas1;
            }
            Mas mas = new Mas();
            int count = mas1.Matrix.Count - 1;
            for (int i = 0; i < count; i++)
            {
                mas.addToMas(mas1[i] * mas1[i + 1] + mas2[i] * mas2[i + 1]);

            }
            return mas;
        }

        public void addRange(Mas mas, double[] matrix) { 
            
            mas.matrix.AddRange(matrix);
            
        }
      

     
        public Mas FromRowToMas(DataGridViewRow row) {
            Mas mas = new Mas();



            for (int i = 0; i < row.Cells.Count; i++)
            {
                string rowValue = row.Cells[i].Value?.ToString();
                if (rowValue == null)
                {
                    MessageBox.Show("Все ячейки должны быть заполнены числами");
                    break;
                }
                Debug.Write(rowValue + " ");
                try
                {
                    if (double.TryParse(rowValue, out double value))
                    {
                        mas.addToMas(Convert.ToDouble(rowValue));
                    }


                    else { throw new FormatException();  }
                }
                catch { MessageBox.Show("Все ячейки должны быть заполнены числами"); break; }
               
            }
            Debug.WriteLine("");
            return mas;
        
        }
    
    }

         

    }

