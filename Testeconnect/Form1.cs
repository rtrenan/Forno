using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Modbus.Device;


namespace Testeconnect
{
    public partial class Form1 : Form
    {
        SerialPort ports = new SerialPort();

        bool funct = false;
        bool funct1 = false;
        uint fun1 = 0;
        float time_s = 0;
        float time_m = 0;
        float time_h = 0;

        float t1 = 0;
        float t2 = 0;
        float t3 = 0;
        float t4 = 0;
        float ttotal = 0;
        int temp_h = 0;
        int temp_l = 0;



        public Form1()
        {
            InitializeComponent();
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_sol.BackColor = Color.LightSalmon;
            btn_for.BackColor = Color.LightSalmon;
        }
                       
        private void timer1_Tick(object sender, EventArgs e)
        {
            IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(ports);
            byte slaveId = Convert.ToByte(txtslave.Text);
            ushort startAddress = Convert.ToUInt16(txtaddress.Text);

            master.WriteSingleRegister(slaveId, 47, Convert.ToUInt16(fun1));

            if (time_s < t1)
            {
                master.WriteSingleCoil(slaveId, 2, false);
                btn_sol.Text = "DESLIGADO";

                master.WriteSingleCoil(slaveId, 4, false);
                btn_for.Text = "DESLIGADO";

                master.WriteSingleRegister(slaveId, 25, Convert.ToUInt16(temp_h*10));

                
            }

            if (time_s >= t1 && time_s < t2)
            {

                master.WriteSingleCoil(slaveId, 4, true);
                btn_for.Text = "LIGADO";
                btn_for.BackColor = Color.LightGreen;
            }

            if (time_s >= t2 && time_s < t3)
            {
                master.WriteSingleCoil(slaveId, 2, true);
                btn_sol.Text = "LIGADO";
                btn_sol.BackColor = Color.LightGreen;
                master.WriteSingleRegister(slaveId, 25, Convert.ToUInt16(temp_l*10));

                master.WriteSingleCoil(slaveId, 4, false);
                btn_for.Text = "DESLIGADO";
                btn_for.BackColor = Color.LightSalmon;
            }

            if (time_s >= t3 && time_s < t4)
            {
                master.WriteSingleCoil(slaveId, 2, false);
                btn_sol.Text = "DESLIGADO";
                btn_sol.BackColor = Color.LightSalmon;

                master.WriteSingleCoil(slaveId, 4, true);
                btn_for.Text = "LIGADO";
                btn_for.BackColor = Color.LightGreen;
            }

            if (time_s >= t4)
            {
                master.WriteSingleCoil(slaveId, 2, false);
                btn_sol.Text = "DESLIGADO";
                btn_sol.BackColor = Color.LightSalmon;

                master.WriteSingleCoil(slaveId, 4, false);
                btn_for.Text = "DESLIGADO";
                btn_for.BackColor = Color.LightSalmon;
            }

                // Crônometro--------------------------------------------------------------------------------------------------


                if (time_s <= 59)
            {
                if (time_s < 10)
                {
                    txt_time.Text = Convert.ToString(time_h) + "0:0" + Convert.ToString(time_m) + ":0" + Convert.ToString(time_s);
                }
                else
                {
                    txt_time.Text = Convert.ToString(time_h) + "0:0" + Convert.ToString(time_m) + ":" + Convert.ToString(time_s);
                }
                
            }

            else if (time_m <= 59)
            {
                time_m++;
                time_s = 0;
                if (time_m < 10)
                {
                    txt_time.Text = Convert.ToString(time_h) + "0:0" + Convert.ToString(time_m) + ":0" + Convert.ToString(time_s);
                }
                else
                {
                    txt_time.Text = Convert.ToString(time_h) + "0:" + Convert.ToString(time_m) + ":" + Convert.ToString(time_s);
                }
            }
            else if (time_h < 999)
            {
                time_h++;
                time_s = 0;
                time_m = 0;
                if (time_h < 10)
                {
                    txt_time.Text = "0" + Convert.ToString(time_h) + ":0" + Convert.ToString(time_m) + ":0" + Convert.ToString(time_s);
                }
                else
                {
                    txt_time.Text = Convert.ToString(time_h) + ":" + Convert.ToString(time_m) + ":" + Convert.ToString(time_s);
                }
            }
            time_s++;


            //-------------------------------------------------------------------------------------------------------------

            //Escrita/Leitura dos Registradores



            ushort[] holding_register = master.ReadHoldingRegisters(slaveId, startAddress, 2);

            float valor = Convert.ToSingle(holding_register[0]);
            float valor1 = Convert.ToSingle(holding_register[1]);

            leitura.Text = Convert.ToString(valor1/10);
            leitura2.Text = Convert.ToString(valor/10);

                     
            
            // write single Coil

            //master.WriteSingleCoil(slaveId, 4, funct1);

            // write single Register


            //-------------------------------------------------------------------------------------------------------------


            //else
            //{
            // master.WriteSingleCoil(slaveId, 2, funct);
            //}



        }

        private void button1_Click(object sender, EventArgs e)
                   
      {
            try
            {
                if (ports.IsOpen)
                {
                    timer1.Enabled = false;
                    ports.Close();
                    button1.Text = "Desconnected";
                    button1.BackColor = Color.Red;

                                       

                    time_h = 0;
                    time_s = 0;
                    time_m = 0;

                    txt_time.Text = Convert.ToString(time_h) + ":" + Convert.ToString(time_m) + ":" + Convert.ToString(time_s);

                    fun1 = 0;
                   


                }
                else
                {
                    timer1.Enabled = true;
                    ports.Open();
                    button1.Text = "Connected";
                    button1.BackColor = Color.Green;

                    fun1 = 1;
                    
                                    }
            }
            catch(Exception err)
            {
                MessageBox.Show("Erro de Porta!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ports.Close();
        }

        private void comunicaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            

            ports.PortName = form2.comboBox1.Text;
            ports.BaudRate = Convert.ToInt16(form2.comboBox2.Text);
            ports.DataBits = Convert.ToByte(form2.comboBox4.Text);
            ports.Parity = (Parity)Enum.Parse(typeof(Parity), form2.comboBox3.Text);
            ports.StopBits = (StopBits)Enum.Parse(typeof(StopBits), form2.comboBox5.Text);

        }

        private void rampaTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

            t1 = Convert.ToInt16(form3.txt_t1.Text);
            t2 = Convert.ToInt16(form3.txt_t2.Text);
            t3 = Convert.ToInt16(form3.txt_t3.Text);
            t4 = Convert.ToInt16(form3.txt_t4.Text);
            ttotal = Convert.ToInt16(form3.txt_total.Text);
            temp_h = Convert.ToInt16(form3.txt_temph.Text);
            temp_l = Convert.ToInt16(form3.txt_templ.Text);


        }

        private void btn_sol_Click(object sender, EventArgs e)
        {
            if (funct == false)
            {
                funct = true;
                btn_sol.Text = "LIGADO";
                btn_sol.BackColor = Color.LightGreen;
            }
            else if (funct == true){
                funct = false;
                btn_sol.Text = "DESLIGADO";
                btn_sol.BackColor = Color.LightCoral;
            }
                 
        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            if (funct1 == false)
            {
                funct1 = true;
                btn_for.Text = "LIGADO";
                btn_for.BackColor = Color.LightGreen;
            }
            else if (funct1 == true)
            {
                funct1 = false;
                btn_for.Text = "DESLIGADO";
                btn_for.BackColor = Color.LightCoral;
            }
        }

       
    }
}