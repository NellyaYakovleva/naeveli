using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class resultForm : Form
    {
        public resultForm(string text, string endSymbols)
        {
            InitializeComponent();

            dataGridView.Rows.Clear();
            listBox.Items.Clear();
            int wordCounter = 0;

            // Stopwatch begin
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            //Thread.Sleep(7000);

            var count = new Dictionary<string, double>();
            string[] wordArr = text.Split(endSymbols.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < wordArr.Length; i++)
            {
                if (count.ContainsKey(wordArr[i]))
                    count[wordArr[i]] += 1;
                else
                    count.Add(wordArr[i], 1);

                wordCounter++;
            }

            var countKeys = count.Keys.ToList();
            countKeys.Sort();

            label2.Text += wordCounter;
            label4.Text += wordCounter;

            foreach (var countKeysTemp in countKeys)
            {
                dataGridView.Rows.Add(countKeysTemp, count[countKeysTemp], Convert.ToString(Math.Round(count[countKeysTemp] / Convert.ToDouble(wordArr.Length), 3) * 100 + "%"));
                listBox.Items.Add(countKeysTemp + "[" + count[countKeysTemp] + "] = " + Math.Round(count[countKeysTemp] / Convert.ToDouble(wordArr.Length), 5));
            }

            // Stopwatch end
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            testLabel.Text += ts;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
