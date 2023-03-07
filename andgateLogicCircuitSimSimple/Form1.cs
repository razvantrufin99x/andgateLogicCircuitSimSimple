using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace andgateLogicCircuitSimSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        circuitelectriccuintrerupatoare circuitulAND1 = new circuitelectriccuintrerupatoare();
        circuitelectriccuintrerupatoare circuitulAND2 = new circuitelectriccuintrerupatoare();


      
   



        private void Form1_Load(object sender, EventArgs e)
        {

            //AND GATE 1
            circuitulAND1.listaIntrerupatoareIntrare.Add(this.intrerupator1);
            circuitulAND1.listaIntrerupatoareIntrare.Add(this.intrerupator2);
            circuitulAND1.listaIntrerupatoareIesire.Add(this.intrerupator3);
            //AND GATE 2
            circuitulAND2.listaIntrerupatoareIntrare.Add(this.intrerupator4);
            circuitulAND2.listaIntrerupatoareIntrare.Add(this.intrerupator5);
            circuitulAND2.listaIntrerupatoareIesire.Add(this.intrerupator6);


           

        }


        //i use this function just to preset the next in link list of intrerupator
        //linked so c1o1 linked to c2i1 but before you must put the value of c2i1 to be the other value of
        //c1o1 and then circuitulAND2 will change its value so will be same as c1o1 where he is linked 
        public bool setNextInLink()
        {
            if (circuitulAND1.listaIntrerupatoareIesire[0].value == "ON") { circuitulAND2.listaIntrerupatoareIntrare[0].value = "OFF"; return true; }
            else if (circuitulAND1.listaIntrerupatoareIesire[0].value == "OFF") { circuitulAND2.listaIntrerupatoareIntrare[0].value = "ON"; return false; }
            else { return true; }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AND I1,I2 AND O3
            circuitulAND1.ANDLogic(circuitulAND1.listaIntrerupatoareIntrare[0], circuitulAND1.listaIntrerupatoareIntrare[1], circuitulAND1.listaIntrerupatoareIesire[0]);
            setNextInLink();

            circuitulAND2.listaIntrerupatoareIntrare[0].setUp();
                circuitulAND2.listaIntrerupatoareIntrare[0].startUp();
            circuitulAND2.ANDLogic(circuitulAND2.listaIntrerupatoareIntrare[0], circuitulAND2.listaIntrerupatoareIntrare[1], circuitulAND2.listaIntrerupatoareIesire[0]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           


           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //AND I1,I2 AND O3
            circuitulAND2.ANDLogic(circuitulAND2.listaIntrerupatoareIntrare[0], circuitulAND2.listaIntrerupatoareIntrare[1], circuitulAND2.listaIntrerupatoareIesire[0]);

        }
    }
}
