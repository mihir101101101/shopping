using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    /*interface emp_details
    {
        void set(int n,string name);
    }*/

   
    class employee
    {
        public int emp_no, emp_p;
        public string emp_fname, emp_lname, emp_add, emp_city, emp_s;
        public void set_employee()
        {

            Console.Write("Enter Employee no: ");
            emp_no = Convert.ToInt32(Console.ReadLine());
            /*Console.Write("Enter employee Firstname: ");
            emp_fname = Console.ReadLine();
            Console.Write("Enter employee Lastname: ");
            emp_lname = Console.ReadLine();
            Console.Write("Enter employee Address: ");
            emp_add = Console.ReadLine();
            Console.Write("Enter employee City: ");
            emp_city = Console.ReadLine();
            Console.Write("Enter employee State: ");
            emp_s = Console.ReadLine();
            Console.WriteLine("Enter employee PostalCode: ");
            emp_p = Convert.ToInt32(Console.ReadLine());*/

        }
    }

    class product
     {
         public int p_no;
         public double unit_p,dis;
         public string p_name;

         public void set_products()
         {
             Console.Write("Enter Product No: ");
             p_no = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter Product Name: ");
             p_name = Console.ReadLine();
             Console.Write("Enter unit Prize: ");
             unit_p = Convert.ToDouble(Console.ReadLine());
         }


     }

    class orderdetails
     {
         product ob3 = new product();
         public int quan;
         public double u_prize, amount, dis_amount, gt;
         DateTime c_date, m_date;

         public void set_prodetails()
         {
             ob3.set_products();
             Console.Write("Enter the quantity: ");
             this.quan = Convert.ToInt32(Console.ReadLine());
             this.u_prize = ob3.unit_p;
             this.amount = this.quan * this.u_prize;
             Console.Write("Enter the Discount amount: ");
             this.dis_amount = Convert.ToDouble(Console.ReadLine());
             this.gt = this.amount - this.dis_amount;
             this.c_date = DateTime.Now;
             this.m_date = DateTime.Now;
         }

         public void show_p()
         {
             this.amount = this.quan * this.u_prize;
             this.gt = this.amount - this.dis_amount;
             Console.WriteLine(ob3.p_no +"\t\t" +ob3.p_name+"\t\t"+this.u_prize+"\t\t"+this.quan+"\t\t"
                 +this.amount+"\t\t"+this.dis_amount+"\t\t"+this.gt);
         }

         public void show_2()
         {
             Console.WriteLine(ob3.p_no + "\t\t" + this.quan);
         }

         public Boolean check(int k)
         {
             if (k == ob3.p_no)
             {

                 Console.WriteLine("\nProduct do exists:-----");
                 return true;
                 
             }
             else
             {
                 return false;
             }
         }

         public void change(int q,int p)         
         {
             if (p == ob3.p_no)
             {
                 this.quan = q;
                 Console.WriteLine("\nQuantity has been Updated:------------");
             }
             
            
         }




     }


    /*public interface c_details
    {
        public void show();
        public void set(int n, string name);
    }*/


    class customer
    {
        public int c_no,c_pcode;
        public string c_name,c_add,c_city,c_state,c_con;
        public void set_customer()
        {
            Console.Write("Enter cutomer no.:");
            c_no = Convert.ToInt32(Console.ReadLine());
            /*Console.Write("Enter customer name.:");
            c_name = Console.ReadLine();
            
            Console.Write("Enter customer Address: ");
            c_add = Console.ReadLine();
            Console.Write("Enter customer City: ");
            c_city = Console.ReadLine();
            Console.Write("Enter customer State: ");
            c_state = Console.ReadLine();
            Console.Write("Enter customer Country: ");
            c_con = Console.ReadLine();
            Console.Write("Enter customer PostalCode: ");
            c_pcode = Convert.ToInt32(Console.ReadLine());*/
            

        }

    }


    class order
    {
        
        employee ob1 = new employee();
        customer ob2 = new customer();
        
        public int or_no, s_pcode;
        public string s_name, s_add, s_city, s_state, s_country;
        DateTime date, c_date, m_date;

        public void set_order(int p)
        {

            or_no = p;
            Console.WriteLine("\nEnter employee details:-----------------------");
            ob1.set_employee();
            Console.WriteLine("\nEnter customer details:-----------------------");
            ob2.set_customer();
           Console.Write("Enter the Order date: (**Only in dd/mm/yyyy format): ");
            date = Convert.ToDateTime(Console.ReadLine());

            this.s_name = ob2.c_name;
            this.s_add = ob2.c_add;
            this.s_city = ob2.c_city;
            this.s_state = ob2.c_state;
            this.s_country = ob2.c_con;
            this.c_date = DateTime.Now;
            this.m_date = DateTime.Now;

        }

        public void show1()
        {
            Console.Write(or_no+"\t\t");
        
        }
         
        public void showall()
        {
           
            Console.WriteLine(or_no+"\t\t"+ob1.emp_no + "\t\t" +
                ob2.c_no + "\t\t" +s_name);
        }


        public void checksum(order o)
        {
            this.ob1 = o.ob1;
            this.ob2 = o.ob2;
        }

    }



    class sample
    {
        static void Main(String[] args)
        {

            int n,of=0,flag=0,or;
            order[] ob = new order[200];
            orderdetails[] ob1 = new orderdetails[200];
  
            while (true)
            {
            l3: Console.WriteLine("Enter the option from the following :");
                Console.WriteLine("1. Order Entry\n2. Last order details\n3. last order's unit price");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {

                    case 1:
                        {
                            int n1,b,order_no;
                        l2: Console.WriteLine("------------------------------:");
                            Console.WriteLine("1. Add order\n2. Update order\n3. Delete order");
                            Console.WriteLine("------------------------------:");
                            n1 = Convert.ToInt32(Console.ReadLine());

                            
                            switch (n1)
                            {
                                case 1:
                                    {
                                        if (flag == 0)
                                        {

                                            flag = 1;
                                        }
                                        else
                                        {
                                            of++;
                                        }
                                        Console.WriteLine("-------------------------------------------------------");
                                        Console.WriteLine("Enter the order details");
                                        Console.WriteLine("-------------------------------------------------------");


                                            ob[of] = new order();
                                            ob1[of] = new orderdetails();
                                            Console.Write("Enter the order no:-");
                                            order_no=Convert.ToInt32(Console.ReadLine());
                                            if (of == 0)
                                            {
                                                ob[of].set_order(order_no);
                                            }
                                            else
                                            {
                                                for (int i = 0; i < of; i++)
                                                {
                                                    if (ob[i] == null)
                                                        continue;
                                                    if (ob[i].or_no == order_no)
                                                    {
                                                        ob[of] = ob[i];
                                                        goto k;
                                                    }
                                                    
                                                }
                                                
                                                   
                                                        ob[of].set_order(order_no);
                                                       
                                            }

                                            k:ob[of].showall();
                                                ob1[of].set_prodetails();
       
                                        Console.WriteLine("Order No.\tProduct No.\tProduct Name\tUnitPrice\tQuantity\tAmount\tDiscount Amount\tGrand Total");
                                        for (int i = 0; i <= of; i++)
                                        {
                                            if (ob[i] == null)
                                                continue;
                                            ob[i].show1();
                                            ob1[i].show_p();
                                        }

                                        Console.WriteLine("Wanted to save or not if YES press 1 if no press 2: ");
                                        b= Convert.ToInt32(Console.ReadLine());
                                        if (b == 1)
                                        {
                                            continue;
                                        }
                                        else if (b == 2)
                                        {
                                            of--;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Again:");
                                        }
                       
                               break;

                        }

                                case 2:
                                    {

                                        int p_no,qun;
                                        Boolean check;
                                        Console.WriteLine("Enter order details:-----------------------------");
                                        Console.Write("Enter Order no:");
                                        or = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Product details:-----------------");
                                        Console.WriteLine("Product No.\tQty");
                                        for (int i = 0; i <= of; i++)
                                        {
                                            if (ob[i].or_no == or)
                                            {
                                                ob1[i].show_2();
                                            }
                                            else
                                            {
                                                Console.WriteLine("There's no product with this " + or + "Order No");
                                            }
                                        }

                                        Console.WriteLine("Enter the product no for which qty needs to be updated:");
                                        p_no = Convert.ToInt32(Console.ReadLine());
                                        for (int i = 0; i <= of; i++)
                                        {
                                           check= ob1[i].check(p_no);
                                           if (check == true)
                                           {
                                               Console.WriteLine("Enter the quantity that you want to update:");
                                               qun = Convert.ToInt32(Console.ReadLine());

                                               for (int j = 0; j <= of; j++)
                                               {
                                                   ob1[j].change(qun, p_no);
                                               }

                                               break;
                                           }
                                        }

                                       
                                       
                                            break;

                                    }


                                case 3:
                                    {
                                        int d;
                                        order [] oj = new order[200];
                                        oj = ob;

                                        Console.WriteLine("Product No.\tProduct Name\tUnitPrice\tQuantity\tAmount\tDiscount Amount\tGrand Total");
                                        for (int i = 0; i <= of; i++)
                                        {
                                            ob1[i].show_p();
                                        }

                                        Console.WriteLine("Delete any order deatails---------------------");
                                        Console.WriteLine("Enter the order no: ");
                                        d = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Order No.\tProduct No.\tProduct Name\tUnitPrice\tQuantity\tAmount\tDiscount Amount\tGrand Total");
                                        for (int i = 0; i <= of; i++)
                                        {
                                            if (ob[i] == null)
                                                continue;
                                            if (ob[i].or_no == d)
                                            {
                                                ob[i].show1();
                                                ob1[i].show_p();

                                                ob = ob.Where(s => s != ob[i]).ToArray(); // <-----------delete order deatils--------->
                                                
                                            }
                                        }


                                        of--;

                                        Console.WriteLine("----------------------------------------------------------------------\n\n\n");
                                        Console.WriteLine("Order No.\tProduct No.\tProduct Name\tUnitPrice\tQuantity\tAmount\tDiscount Amount\tGrand Total");

                                        
                                        for (int i = 0; i <= of; i++)
                                        {
                                            if (ob[i] == null)
                                                continue;
                                            ob[i].show1();
                                            ob1[i].show_p();
                                        }

                                  

                                            break;
                                    
                                    
                                    
                                    }
                                default:
                                    {

                                        goto l2;
                                    }
                            }

                            break;

                        }


                    case 2:
                        {

                            Console.WriteLine("This was the last order details:\n\n");
                            Console.WriteLine("Product No.\tProduct Name\tUnitPrice\tQuantity\tAmount\tDiscount Amount\tGrand Total");

                            for (int i = 0; i <= of; i++)
                            {
                                if(i==of)
                                    ob1[i].show_p();  
                            }

                            break;
                        }

                    case 3:
                        {

                            Console.WriteLine("This was the last order's unit price:\n\n");
                            Console.WriteLine("UnitPrice");
                            for (int i = 0; i <= of; i++)
                            {
                                if (i == of)
                                    Console.WriteLine(ob1[i].u_prize);
                            }
                            break;
                        }

                    default:
                        {

                            goto l3;
                        }

                }

            }
            //Console.ReadKey();

        }

    }
}

