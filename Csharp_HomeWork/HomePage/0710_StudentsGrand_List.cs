using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class _0710_StudentsGrand_List : Form
    {
        public _0710_StudentsGrand_List()
        {
            InitializeComponent();
        }

        //List<MyScore> myScoreList = new List<MyScore>();
        List<Student> studentList = new List<Student>();
        private void addScore_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                Add_Score();
            }
        }

        public bool Validation()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("請輸入姓名", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBoxChi.Text))
            {
                MessageBox.Show("請輸入國文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBoxEng.Text))
            {
                MessageBox.Show("請輸入英文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBoxMath.Text))
            {
                MessageBox.Show("請輸入數學成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        Student student = new Student();
        void Add_Score()
        {
            student.Name = textBoxName.Text; //姓名
            student.SubjectList = new List<Subject>();

            // make data
            string[] sub_arr = new string[] { "國文", "英文", "數學" };
            string[] score_arr = new string[] { textBoxChi.Text, textBoxEng.Text, textBoxMath.Text };
            for (int i = 0; i < sub_arr.Length; i++)
            {
                Subject subject = new Subject();
                subject.Name = sub_arr[i];
                subject.Score = int.Parse(score_arr[i]);

                student.SubjectList.Add(subject);
            }

            student.Total = student.SubjectList.Sum(x => x.Score);
            student.Average = student.Total / 3;

            var max = student.SubjectList.OrderByDescending(x => x.Score).First();
            student.MaxScore = max.Score;
            var min = student.SubjectList.OrderBy(x => x.Score).First();
            student.MinScore = min.Score;

            studentList.Add(student);

            ListViewItem lv_item = new ListViewItem(new[] { student.Name,
                                                                                        student.SubjectList[0].Score.ToString(),
                                                                                        student.SubjectList[1].Score.ToString(),
                                                                                        student.SubjectList[2].Score.ToString(),
                                                                                        student.Total.ToString(),
                                                                                        student.Average.ToString(),
                                                                                        max.Name + " : " + student.MaxScore.ToString(),
                                                                                        min.Name + " : " + student.MinScore.ToString()});

            listView.Items.Add(lv_item);
        }

       
        private void randomScore_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(Score);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void randomScore_Click_1(object sender, EventArgs e)
        {
            if (Validation())
            {
                Insert_Score();
            }
        }

        void Insert_Score()
        {
            //Student student = new Student();
            student.Name = textBoxName.Text; //姓名
            student.SubjectList = new List<Subject>();

            // make data
            string[] sub_arr = new string[] { "國文", "英文", "數學" };
            string[] score_arr = new string[] { textBoxChi.Text, textBoxEng.Text, textBoxMath.Text };
            for (int i = 0; i < sub_arr.Length; i++)
            {
                Subject subject = new Subject();
                subject.Name = sub_arr[i];
                subject.Score = int.Parse(score_arr[i]);

                student.SubjectList.Add(subject);
            }

            student.Total = student.SubjectList.Sum(x => x.Score);
            student.Average = student.Total / 3;

            var max = student.SubjectList.OrderByDescending(x => x.Score).First();
            student.MaxScore = max.Score;
            var min = student.SubjectList.OrderBy(x => x.Score).First();
            student.MinScore = min.Score;

            studentList.Add(student);

            ListViewItem lv_item = new ListViewItem(new[] { student.Name,
                                                                                        student.SubjectList[0].Score.ToString(),
                                                                                        student.SubjectList[1].Score.ToString(),
                                                                                        student.SubjectList[2].Score.ToString(),
                                                                                        student.Total.ToString(),
                                                                                        student.Average.ToString(),
                                                                                        max.Name + " : " + student.MaxScore.ToString(),
                                                                                        min.Name + " : " + student.MinScore.ToString()});
            listView.Items.Insert(0, lv_item);
        }

        private void BtnSubjectCount_Click(object sender, EventArgs e)
        {

            if (this.listView.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("確定要刪除此筆資料嗎?", "警告！", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    for (int i = this.listView.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem itm = this.listView.SelectedItems[i];
                        this.listView.Items[itm.Index].Remove();
                    }
                }
            }
            else if (this.listView.Items.Count == 0)
            {
                MessageBox.Show("請先新增資料再做刪除");
            }
            else
            {
                MessageBox.Show("請選取要刪除的資料");
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            listView.Items.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            int minVal = int.Parse(textBox1.Text);
            int maxVal = int.Parse(textBox2.Text);

            // 暫停 ListView 的更新
            listView.BeginUpdate();

            // 搜尋ListView控件中的項目
            foreach (ListViewItem item in listView.Items)
            {
                int val = int.Parse(item.SubItems[1].Text);  // 假設您要搜尋的是ListView的第二個子項目

                if (val >= minVal && val <= maxVal)
                {
                    item.Selected = true;
                    item.ForeColor = SystemColors.WindowText;
                }
                else
                {
                    item.Selected = false;
                    item.ForeColor = SystemColors.GrayText;
                }
                item.Selected = false;
            }
            // 恢復 ListView 的更新，並重繪 ListView
            listView.EndUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
