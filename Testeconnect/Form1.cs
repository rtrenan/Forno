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


        public Form1()
        {
            InitializeComponent();

            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
                 // configure serial port
                //port.BaudRate = 9600;
                // port.DataBits = 8;
                //port.Parity = Parity.Even;
                //port.StopBits = StopBits.One;
                //port.Open();

                // create modbus master
                //IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);

               // byte slaveId = 1;
               // ushort startAddress = 10;
                //ushort[] registers = new ushort[] { 1, 2, 3 };
                // ushort[] registers = new ushort[] { 01, 05, 15 };
                // write three registers
                //  master.WriteMultipleRegisters(slaveId, startAddress, registers);
                //ushort[] holding_register = master.ReadHoldingRegisters(slaveId, startAddress, 3);

               // leitura.Text = Convert.ToString(holding_register[0]);
               // leitura2.Text = Convert.ToString(holding_register[1]);
               // leitura3.Text = Convert.ToString(holding_register[2]);

                //ushort[] registers = new ushort[] { 10, 20, 30 };

                // write three registers
                //master.WriteMultipleRegisters(slaveId, startAddress, registers);

                // write single register
                //master.WriteSingleRegister(slaveId, startAddress, ushort.Parse(txt1.Text));

                //ushort[] write_register = master.WriteSingleRegister(slaveId, startAddress, 1);

                 
        }

        private void leitura_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
               
                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(ports);

                byte slaveId = Convert.ToByte(txtslave.Text);
                ushort startAddress = Convert.ToUInt16(txtaddress.Text);

                ushort[] holding_register = master.ReadHoldingRegisters(slaveId, startAddress, 2);

                leitura.Text = Convert.ToString(Convert.ToDouble((holding_register[1])/10));
                leitura2.Text = Convert.ToString(holding_register[0]);

            // write single register

            master.WriteSingleCoil(slaveId, 2, funct);

            
            master.WriteSingleRegister(slaveId, 47, Convert.ToUInt16(funct1));
            master.WriteSingleCoil(slaveId, 4, funct1);


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
                }
                else
                {
                    timer1.Enabled = true;
                    ports.Open();
                    button1.Text = "Connected";
                    button1.BackColor = Color.Green;
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