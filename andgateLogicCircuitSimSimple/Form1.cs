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

        private void button1_Click(object sender, EventArgs e)
        {
            //AND I1,I2 AND O3
            circuitulAND1.ANDLogic(circuitulAND1.listaIntrerupatoareIntrare[0], circuitulAND1.listaIntrerupatoareIntrare[1], circuitulAND1.listaIntrerupatoareIesire[0]);
           
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
