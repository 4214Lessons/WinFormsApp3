using System.Text;

namespace WinFormsApp3;



public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }




    private void Form1_Load(object sender, EventArgs e)
    {

        #region ListBox

        List<string> colors = new()
        {
            "Red",
            "Green",
            "Blue",
            "Cyan",
            "Purple",
            "Pink",
            "Black",
            "White"
        };





        // //// Way 1
        // listBox1.DataSource = colors;








        //// Way 2
        listBox1.Items.AddRange(colors.ToArray());
        // listBox1.SelectedIndex = 2;







        // listBox1.SelectionMode = SelectionMode.None;
        // listBox1.SelectionMode = SelectionMode.One;
        // listBox1.SelectionMode = SelectionMode.MultiSimple;
        listBox1.SelectionMode = SelectionMode.MultiExtended;


        #endregion






        #region MonthCalendar

        // monthCalendar1.BackColor = Color.DarkRed;
        monthCalendar1.BoldedDates = new DateTime[]
        {
            new DateTime(2022,9,24),
            new DateTime(2022,9,25)
        };
        #endregion



        // // comboBox1.SelectedIndex = 0;

    }




    #region MonthCalendarEvents
    private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
    {
        monthCalendar1.MaxSelectionCount = 20;

        lbl_start_date.Text = e.Start.ToShortDateString();
        lbl_end_date.Text = monthCalendar1.SelectionEnd.ToShortDateString();
    }


    private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
    {
        var loc = monthCalendar1.HitTest(e.Location);


        if (loc.HitArea == MonthCalendar.HitArea.Date)
        {
            if (monthCalendar1.BoldedDates.Contains(loc.Time))
                monthCalendar1.RemoveBoldedDate(loc.Time);
            else
                monthCalendar1.AddBoldedDate(loc.Time);
        
        
            monthCalendar1.UpdateBoldedDates();
        }
    }
    #endregion






    #region ListBox Colors
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        // lbl_color.Text = listBox1.Text;
        // lbl_color.Text = listBox1.SelectedIndex.ToString();
        // lbl_color.Text = listBox1.SelectedItem.ToString();



        StringBuilder sb = new StringBuilder();
        
        foreach (var item in listBox1.SelectedItems)
            sb.Append($"{item.ToString()}\n");
        
        lbl_color.Text = sb.ToString();
    }





    private void btn_add_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(tBox_color.Text))
        {
            MessageBox.Show("IsNullOrWhiteSpace");
            return;
        }

        if (!listBox1.Items.Contains(tBox_color.Text))
        {
            // listBox1.Items.Add(tBox_color.Text);
            listBox1.Items.Insert(1, tBox_color.Text);
            
            tBox_color.Text = string.Empty;
        }
        else
            MessageBox.Show("Can not add again same color");
    }

    #endregion






    #region ListBox Students
    private void btn_load_Click(object sender, EventArgs e)
    {

        List<Student> students = new()
        {
            new("Huseyn", "Ibrahimov"),
            new("Leyla", "Shefiyeva"),
            new("Murad", "Meherremli"),
            new("Kenan", "Muradov"),
            new("Ali", "Shamilzade"),
            new("Nihat", "Ekremi")
        };



        lBox_students.Items.AddRange(students.ToArray());

        lBox_students.DisplayMember = "Name";

        // lBox_students.DataSource = students;
        lBox_students.ValueMember = "Id";

    }






    private void lBox_students_SelectedIndexChanged(object sender, EventArgs e)
    {
        Student? student = lBox_students.SelectedItem as Student;
        lbl_student.Text = $"{student?.Id} {student?.Name} {student?.Surname}";
        
        
        
        // lbl_student.Text = lBox_students.SelectedValue?.ToString();
    }





    private void btn_student_Click(object sender, EventArgs e)
    {
        lBox_students.Items.Add(new Student("Elshad", "Hesenov"));
    }



    private void btn_remove_Click(object sender, EventArgs e)
    {
        // lBox_students.Items.Remove(lBox_students.SelectedItem);


        // MessageBox.Show(lBox_students.SelectedIndex.ToString());
        // lBox_students.Items.RemoveAt(lBox_students.SelectedIndex);    


        // lBox_students.Items.Clear();



        // while (lBox_students.SelectedItems.Count > 0)
        //     lBox_students.Items.Remove(lBox_students.SelectedItems[0]);

    }


    private void btn_move_Click(object sender, EventArgs e)
    {
        foreach (var item in lBox_students.SelectedItems)
            lBox_Students_Copy.Items.Add(item);

        // lBox_Students_Copy.Items.AddRange(lBox_students.SelectedItems.Cast<Student>().ToArray());


        while (lBox_students.SelectedItems.Count > 0)
            lBox_students.Items.Remove(lBox_students.SelectedItems[0]);
    }


    #endregion






    #region CheckedListBox

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var item in checkedListBox1.CheckedItems)
            sb.Append($"{item.ToString()}\n");

        label1.Text = sb.ToString();
    }

    #endregion





    #region ComboBox

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MessageBox.Show(comboBox1.Text);
    }


    #endregion

}