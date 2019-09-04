using c300_kitabxana.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c300_kitabxana
{
    public partial class addbook : Form
    {
        libdb db = new libdb();
        public addbook()
        {
            InitializeComponent();
        }

        private void Addbook_Load(object sender, EventArgs e)
        {
            cmbauthor.Items.AddRange(db.Authors.Select(a=>a.Name).ToArray());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string bookname = txtbookname.Text;
            string count = txtcount.Text;
            DateTime createdate = dtcreatename.Value;
            string authorname = cmbauthor.Text;
            int newCount ;
            if (bookname!="" && count != "" && authorname != "")
            {
                if (int.TryParse(count,out newCount))
                {
                    int? authorId = db.Authors.FirstOrDefault(a => a.Name == authorname).Id;
                    book selectBook = db.books.FirstOrDefault(b => b.Name == bookname);
                    if(selectBook==null)
                    {
                        if(authorId != null)
                        {
                            lbleror.Visible = false;
                            book bk = new book();
                            bk.Name = bookname;
                            bk.productionDate = createdate;
                            bk.Counts = newCount;
                            bk.AuthorId = authorId;
                            db.books.Add(bk);
                            db.SaveChanges();
                            MessageBox.Show("Books Create successfully");
                        }
                        else
                        {
                            lbleror.Text = "Yazar adi movcuddur";
                            lbleror.Visible = true;
                        }
                    }
                    else
                    {
                        lbleror.Text = "Bu adli kitab movcuddur";
                        lbleror.Visible = true;
                    }
               
                }
                else
                {
                    lbleror.Text = "zehmet olmasa reqem daxil edin";
                    lbleror.Visible = true;
                }
            }
            else
            {
                lbleror.Text = "zehmet olmasa bow gondermeyin";
                lbleror.Visible = true;
            }
        }
    }
}
