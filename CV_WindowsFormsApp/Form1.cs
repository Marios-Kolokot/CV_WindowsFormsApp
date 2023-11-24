using CV_WindowsFormsApp.DataBaseContext;
using CV_WindowsFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CV_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private string _textboxCandidateFName;
        private string _textboxCandidateLastName;
        private string _textboxCandidateEmail;
        private string _textboxCandidateMobile;
        private string _textboxCandidateDegree;
        Degree myselectedDegree;
        Candidate mySelectedRowCandidate;
        DataGridViewRow selectedRow;

        List<Candidate> ListOfCandidates= new List<Candidate>();
        List<Degree> ListOfDegrees= new List<Degree>();



        public Form1()
        {
            InitializeComponent();

            MyDbContext context = new MyDbContext();

            ListOfCandidates = context.Candidates.ToList();

            ListOfDegrees = context.Degrees.ToList();

            comboBox1.DataSource = ListOfDegrees;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            
            dataGridView1.DataSource = ListOfCandidates;
            dataGridView1.Columns[0].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void comboBox1DegreeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            myselectedDegree = comboBox1.SelectedItem as Degree;

            if (myselectedDegree != null)
            {
                Console.WriteLine(myselectedDegree.Name);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //mySelectedRowCandidate

            selectedRow = dataGridView1.CurrentRow;

            mySelectedRowCandidate = (Candidate)selectedRow.DataBoundItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button5UploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a File to Upload";
            openFileDialog.Filter = "All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                MessageBox.Show($"Selected File: {selectedFilePath}", "File Upload");
            }
        }

        private void textBox1FName_TextChanged(object sender, EventArgs e)
        {
            _textboxCandidateFName = textBox1.Text;
        }

        private void textBox2LName_TextChanged(object sender, EventArgs e)
        {
            _textboxCandidateLastName= textBox2.Text;
        }

        private void textBox3Email_TextChanged(object sender, EventArgs e)
        {
            _textboxCandidateEmail=textBox3.Text;
        }

        private void textBox4Mobile_TextChanged(object sender, EventArgs e)
        {
            _textboxCandidateMobile=textBox4.Text;
        }
       

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Create Save Mode
            Candidate newcandidate = new Candidate();
            newcandidate.FirstName = _textboxCandidateFName;
            newcandidate.LastName = _textboxCandidateLastName;
            newcandidate.Email = _textboxCandidateEmail;
            newcandidate.Mobile = _textboxCandidateMobile;
            newcandidate.MyDateTime= DateTime.Now;
            newcandidate.Degree = myselectedDegree.Name;

            //Save to DataBase
            MyDbContext myDbContext = new MyDbContext();
            myDbContext.Candidates.Add(newcandidate);
            myDbContext.SaveChanges();

            //Add object to List
            //ListOfCandidates.Add(newcandidate);
            ListOfCandidates = myDbContext.Candidates.ToList();
            dataGridView1.DataSource = ListOfCandidates;

            dataGridView1.Refresh();

            
            //var mylist = myselectedDegree.to
            //newcandidate.DegreesList
            //myselectedDegree
            //_textboxCandidateDegree

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4RefreshGrid_Click(object sender, EventArgs e)
        {
            MyDbContext myDbContext = new MyDbContext();
            ListOfCandidates = myDbContext.Candidates.ToList();
            dataGridView1.DataSource = ListOfCandidates;
            dataGridView1.Refresh();
        }

        private void button2DeleteCandidate_Click(object sender, EventArgs e)
        {
            if ( mySelectedRowCandidate != null)
            {
                MyDbContext myDbContext = new MyDbContext();

                    myDbContext.Candidates.Remove(mySelectedRowCandidate);
                    myDbContext.SaveChanges();
 
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                ListOfCandidates.Remove(mySelectedRowCandidate);
            }
        }
    }
}
