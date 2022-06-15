using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        Person person1;
        Person person2;
        Person person3;
        Person person4;
        Person selectedPerson;

        private Meal meal1;
        private Meal meal2;
        private Meal meal3;
        private Meal meal4;
        private Meal meal5;
        private Meal selectedMeal;

        public Form1()
        {
            InitializeComponent();
            person1 = new Person("Jim");
            person2 = new Person("Myron");
            person3 = new Person("Lars");
            person4 = new Person("Sam");
            selectedPerson = new Person();
            

            meal1 = new Meal("Potted Crab", 14.99);
            meal2 = new Meal("Tomatoes, Burrata and Broad Bean Salad", 18.99);
            meal3 = new Meal("Beer-Brined Beer Can Chicken", 17.99);
            meal4 = new Meal("Spring Risotto", 19.99);
            meal5 = new Meal("Avocado Chocolate Mousse", 11.99);
            selectedMeal = new Meal();
        }

        /* bool buttonPressed = false;
         private void btnAddName_Click(object sender, System.EventArgs e)
         {
             if (!buttonPressed)
             {
                 int i = 0;
                 while (i < 4)
                 { person1.Setname(tbName.Text);
                   rbPerson1.Text = person1.getName();

                 }

           buttonPressed = true;
             } else 
             {
                 tbName.Text = "";
             }
        */

        private void btnAddName_Click(object sender, System.EventArgs e)
        { 
        }

        private void btnShowMealInfo_Click(object sender, System.EventArgs e)
        {
            rbMeal1.Text = meal1.getMealInfo();
            rbMeal2.Text = meal2.getMealInfo();
            rbMeal3.Text = meal3.getMealInfo();
            rbMeal4.Text = meal4.getMealInfo();
            rbMeal5.Text = meal5.getMealInfo();
        }
        
        private void rbPerson1_CheckedChanged(object sender, System.EventArgs e)
        {
            selectedPerson = person1;
        }

        private void rbPerson2_CheckedChanged(object sender, System.EventArgs e)
        {
            selectedPerson = person2;
        }

        private void rbPerson3_CheckedChanged(object sender, System.EventArgs e)
        {
            selectedPerson = person3;
        }

        private void rbPerson4_CheckedChanged(object sender, System.EventArgs e)
        {
            selectedPerson = person4;
        }
        

        private void rbMeal1_CheckedChanged(object sender, System.EventArgs e)
        {
            selectedMeal = meal1;
        }

        private void rbMeal2_CheckedChanged(object sender, System.EventArgs e)
        {
            selectedMeal = meal2;
        }

        private void rbMeal3_CheckedChanged(object sender, System.EventArgs e)
        {
            selectedMeal = meal3;
        }

        private void rbMeal4_CheckedChanged(object sender, System.EventArgs e)
        {
            selectedMeal = meal4;
        }

        private void rbMeal5_CheckedChanged(object sender, System.EventArgs e)
        {
            selectedMeal = meal5;
        }


        private void btnPlaceOrder_Click(object sender, System.EventArgs e)
        {
       
            if (rbPerson1.Checked)
            {
                 person1.setMeal(selectedMeal);
                 lbClientOrder1.Text = $"{person1.getName()} ordered {person1.GetMealNameInfo()} ";
                 lbOrderPrice1.Text = person1.getMealPriceInfo();
            }
            else if (rbPerson2.Checked)
            {
                person2.setMeal(selectedMeal);
                lbClientOrder2.Text = $"{person2.getName()} ordered {person2.GetMealNameInfo()} ";
                lbOrderPrice2.Text = person2.getMealPriceInfo();
            }
            else if (rbPerson3.Checked)
            {
                person3.setMeal(selectedMeal);
                lbClientOrder3.Text = $"{person3.getName()} ordered {person3.GetMealNameInfo()} ";
                lbOrderPrice3.Text = person3.getMealPriceInfo();
            }
            else if (rbPerson4.Checked)
            {
                person4.setMeal(selectedMeal);
                lbClientOrder4.Text = $"{person4.getName()} ordered {person4.GetMealNameInfo()} ";
                lbOrderPrice4.Text = person4.getMealPriceInfo();
            }

        }

        private void btnMakeOrderFinal_Click(object sender, System.EventArgs e)
        {
            double totalprice = person1.getMealPrice() + person2.getMealPrice() + person3.getMealPrice() + person4.getMealPrice();
            lbTotalPrice.Text = "Euro " + totalprice.ToString();

            btnPlaceOrder.Enabled = false;
        }
    }
}
