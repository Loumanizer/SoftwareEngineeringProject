using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineFoodOrdering
{
    public partial class _Default : Page
    {
        List<string> l1;
        string selectedItemText;
        int SelectedIndex;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            //if (ListBox1.Items.Count == 0)
            //    return;
            //int index = ListBox1.indexfrom
            //string s = ListBox1.Items[index].ToString();
            //if(e.clicks)

            selectedItemText = ListBox1.SelectedItem.ToString();
            SelectedIndex = ListBox1.SelectedIndex;
            ListBox2.Items.Add(selectedItemText);
           // ListBox1.DataSource = 
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//namespace cheflist
//{
//    public partial class _Default : Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }
//        //protected void ListBox1_DoubleClick(object sender, EventArgs e)
//        ////private void fieldsArea_MouseDoubleClick(object sender, MouseEventArgs e)
//        //{
//        //    //int index = this.listBox1.IndexFromPoint(e.Location);
//        //    //if (index != System.Windows.Forms.ListBox.NoMatches)
//        //    //{
//        //    //    MessageBox.Show(index.ToString());
//        //    //}
//        //    //this.fieldsArea.MouseDoubleClick += new MouseEventHandler(fieldsArea_MouseDoubleClick);
//        //    if (ListBox1.Items.Count == 0)
//        //        return;
//        //    int index = ListBox1.inde.IndexFromPoint(e.Location);
//        //    string s = ListBox1.Items[index].ToString();

//        //    if (e.Clicks > 1)
//        //    {
//        //        selectedFieldsArea.Items.Add(s);
//        //    }
//        //    else
//        //    {
//        //        DragDropEffects dde1 = DoDragDrop(s,
//        //        DragDropEffects.All);
//        //    }
//        //}

//        private void fieldsArea_MouseDown(object sender, MouseEventArgs e)
//        {
//            this.fieldsArea.MouseDoubleClick += new MouseEventHandler(fieldsArea_MouseDoubleClick);

//            if (fieldsArea.Items.Count == 0)
//                return;
//            int index = fieldsArea.IndexFromPoint(e.Location);
//            string s = fieldsArea.Items[index].ToString();

//            if (e.Clicks > 1)
//            {
//                selectedFieldsArea.Items.Add(s);
//            }
//            else
//            {
//                DragDropEffects dde1 = DoDragDrop(s,
//                DragDropEffects.All);
//            }
//        }
//        protected void ListBox2_DoubleClick(object sender, EventArgs e)
//        {

//        }
//    }
//}