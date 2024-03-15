using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace 콜라츠추측_횟수비교
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        long CalcSequence = 1, Sequence = 1, Biggest = default;
        int times = 0;
        
        bool flag = true;

        string fileName = "noname.txt";

        List<long> rankNums = new List<long>();

        Func<long, long> Distinguish = x => 
        {
            if (x % 2 == 0)
                return x / 2;
            else  if (x == 1)
                return 1;
            else
                return x * 3 + 1;
        };

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == true)
            {
                MessageBox.Show("계산하는중에는 정리가 불가능합니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RankNums();
        }

        private void RankNums()
        {
            if (listBox1.Items.Count == 0)
                return;

            try
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    rankNums.Add(Convert.ToInt64(listBox1.Items[i]));
                }

                rankNums.Sort();

                listBox1.Items.Clear();

                long biggest = rankNums[rankNums.Count - 1]; // 리스트박스에서 가장 큰 숫자
                int count = 0;

                for (int i = 1; i <= biggest; i++) // 리스트박스에서 가장 큰 숫자만큼 반복
                {
                    for (int j = 0; j < rankNums.Count; j++) // 만약 listBox1.Item[j]가 i랑 같다면 나온횟수 +1
                    {
                        if (rankNums[j] == i)
                            count++;
                    }

                    if(count != 0)
                        listBox1.Items.Add(String.Format("<{0}>: {1}번", i, count));
                    count = 0;
                }

                MessageBox.Show("정리완료!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            CalcSequence = 1; Sequence = 1; Biggest = default;

            rankNums.Clear();
            listBox1.Items.Clear();
            dataGridView1.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                timer1.Enabled = true;

                listBox1.Items.Clear();

                for (int i = 0; i < rankNums.Count; i++)
                    listBox1.Items.Add(rankNums[i]);

                flag = false;
            }
            else
            {
                timer1.Enabled = false;
                flag = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                MessageBox.Show("계산하는중에는 저장이 불가능합니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (listBox1.Items.Count == 0) { return; }

            btnRank_Click(btnRank, null);

            string saveRanks = "";

            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                saveRanks += listBox1.Items[i].ToString() + "\n";
            }

            if (fileName == "noname.txt")
            {
                saveFileDialog1.ShowDialog();
                fileName = saveFileDialog1.FileName;
            }
            StreamWriter sw = File.CreateText(fileName);
            sw.WriteLine(saveRanks);
            sw.Close();
        }

        private void timer1_Tick(object sender, EventArgs e) // 계산
        {
            CalcSequence = Distinguish(CalcSequence);
            listBox1.Items.Add(CalcSequence);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;

            rankNums.Add(Convert.ToInt32(CalcSequence));

            if (CalcSequence > Biggest)
            Biggest = CalcSequence;
                
            times++;

            if(CalcSequence == 1)
            {
                dataGridView1.Rows.Add(Sequence, times, Biggest);
                times = 0;
                Sequence++;
                CalcSequence = Biggest = Sequence;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 7;
        }
    }
}
