using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// 用DllImport
using System.Runtime.InteropServices;
using System.IO;

namespace CSharpCallDll
{
    public partial class Form1 : Form
    {
        [DllImport("win32dll.dll", EntryPoint = "Add", CallingConvention = CallingConvention.StdCall)]
        public static extern int Add(int num1, int num2);
        [DllImport("win32dll.dll", EntryPoint = "AddPtr", CallingConvention = CallingConvention.StdCall)]
        public static extern double AddPtr(ref double num1, ref double num2);
        // C#默认是Unicode的，C++默认是ANSI的，所以需要增加：CharSet = CharSet.Ansi
        [DllImport("win32dll.dll", EntryPoint = "TestParamChar", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr TestParamChar(string s);
        [DllImport("win32dll.dll", EntryPoint = "GetClsObj", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetClsObj();
        [DllImport("win32dll.dll", EntryPoint = "TestCAdd", CallingConvention = CallingConvention.StdCall)]
        public static extern int TestCAdd(IntPtr obj, int num1, int num2);
        [DllImport("win32dll.dll", EntryPoint = "TestParamQuote", CallingConvention = CallingConvention.StdCall)]
        public static extern void TestParamQuote(ref int p);
        [DllImport("win32dll.dll", EntryPoint = "TestParamArray", CallingConvention = CallingConvention.StdCall)]
        public static extern void TestParamArray(int[] arr, int n, ref int sum);
        [DllImport("win32dll.dll", EntryPoint = "TestOutArr", CallingConvention = CallingConvention.StdCall)]
        public static extern void TestOutArr(int n, int[] arr, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] outArr);
        [DllImport("win32dll.dll", EntryPoint = "TestCharArr", CallingConvention = CallingConvention.StdCall)]
        public static extern void TestCharArr([Out, MarshalAs(UnmanagedType.LPArray)]char[] cArr);
        [StructLayout(LayoutKind.Sequential)]
        public struct stuInfo
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public char[] name;
            public int age;
        }
        [DllImport("win32dll.dll", EntryPoint = "TestStruct", CallingConvention = CallingConvention.StdCall)]
        public static extern void TestStruct(ref stuInfo p);
        [DllImport("win32dll.dll", EntryPoint = "TestStructPtr", CallingConvention = CallingConvention.StdCall)]
        public static extern void TestStructPtr(ref stuInfo p);
        [StructLayout(LayoutKind.Sequential)]
        public struct CountStuInfo
        {
            public int count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public stuInfo[] stuInfo;
        }
        [DllImport("win32dll.dll", EntryPoint = "TestStruct2", CallingConvention = CallingConvention.StdCall)]
        public static extern void TestStruct2(ref CountStuInfo cts);
        [DllImport("win32dll.dll", EntryPoint = "TestStruct2", CallingConvention = CallingConvention.StdCall)]
        public static extern void TestStruct2_1(IntPtr myPtr);
        [DllImport("win32dll.dll", EntryPoint = "CSharpGetOpencvPicFromDll_Way1", CallingConvention = CallingConvention.StdCall)]
        public static extern void CSharpGetOpencvPicFromDll_Way1(ref byte data, out ulong size);

        [DllImport("win32dll.dll", EntryPoint = "CSharpGetOpencvPicFromDll_Way2", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CSharpGetOpencvPicFromDll_Way2(out int width, out int height, out int step);
        public Form1()
        {
            InitializeComponent();
        }

        private void normalVar_Click(object sender, EventArgs e)
        {
            int a = 4, b = 5;
            int c = Add(a, b);
            MessageBox.Show(c.ToString());
        }

        private void ptrVar_Click(object sender, EventArgs e)
        {
            double a = 4.2, b = 5.4;
            double c = AddPtr(ref a, ref b);
            MessageBox.Show(c.ToString());
        }

        private void charX_Click(object sender, EventArgs e)
        {
            IntPtr pCharRet = TestParamChar("c# string");
            string strRest = Marshal.PtrToStringAnsi(pCharRet);
            MessageBox.Show(strRest);
        }

        private void callFunInCls_Click(object sender, EventArgs e)
        {
            IntPtr obj = GetClsObj();
            int a = 1, b = 1;
            int c = TestCAdd(obj, a, b);
            MessageBox.Show(c.ToString());
        }

        private void quote_Click(object sender, EventArgs e)
        {
            int p = 10;
            TestParamQuote(ref p);
            MessageBox.Show(p.ToString());
        }

        private void array_Click(object sender, EventArgs e)
        {
            const int size = 6;
            int[] arr = new int[size] { 1, 2, 4, 5, 6, 7 };
            int sum = 0;
            TestParamArray(arr, size, ref sum);
            MessageBox.Show(sum.ToString());
        }

        private void outArr_Click(object sender, EventArgs e)
        {
            const int size = 5;
            int[] inArr = new int[size] { 1, 2, 3, 4, 5 };
            int[] outArr = new int[size];
            TestOutArr(size, inArr, outArr);
            for (int i = 0; i < size; i++)
            {
                MessageBox.Show(outArr[i].ToString());
            }
        }

        private void outCharArr_Click(object sender, EventArgs e)
        {
            char[] c = new char[6] { 'h', 'e', 'l', 'l', 'o', '\0' };
            TestCharArr(c);
            string str_c = new string(c);
            MessageBox.Show(str_c);
        }

        private void structParam_Click(object sender, EventArgs e)
        {
            stuInfo p = new stuInfo();
            TestStruct(ref p);
            string ps = new string(p.name);
            MessageBox.Show(ps);
            MessageBox.Show(p.age.ToString());
        }

        private void structPtr_Click(object sender, EventArgs e)
        {
            stuInfo p = new stuInfo();
            TestStructPtr(ref p);
            string ps = new string(p.name);
            MessageBox.Show(ps);
            MessageBox.Show(p.age.ToString());
        }

        private void struct2_Click(object sender, EventArgs e)
        {
            // 方式一
            //CountStuInfo cst = new CountStuInfo();
            //TestStruct2(ref cst);
            //MessageBox.Show(cst.count.ToString());
            //for (int i = 0; i < cst.count; i++)
            //{
            //    string nameTmp = new string(cst.stuInfo[i].name);
            //    MessageBox.Show(nameTmp);
            //    MessageBox.Show(cst.stuInfo[i].age.ToString());
            //}

            // 方式二
            CountStuInfo cst2 = new CountStuInfo();
            System.Text.ASCIIEncoding aSCII = new ASCIIEncoding();
            IntPtr myPtr = Marshal.AllocHGlobal(Marshal.SizeOf(cst2));
            Marshal.StructureToPtr(cst2, myPtr, true);
            TestStruct2_1(myPtr);
            cst2 = (CountStuInfo)Marshal.PtrToStructure(myPtr, typeof(CountStuInfo));
            Marshal.FreeHGlobal(myPtr);
            for (int i = 0; i < cst2.count; i++)
            {
                string nameTmp = new string(cst2.stuInfo[i].name);
                MessageBox.Show(nameTmp);
                MessageBox.Show(cst2.stuInfo[i].age.ToString());
            }
        }

        private void GetPicWay1_Click(object sender, EventArgs e)
        {
            string s = "dll依赖的opencv版本不是2.4.12的时候用该方法，其他方法不行";
            MessageBox.Show(s);
            //byte[] ptrData = new byte[2048 * 2048 * 3];
            //ulong size = new ulong();
            //CSharpGetOpencvPicFromDll_Way1(ref ptrData[0], out size);
            //pictureBox1.Image = Image.FromStream(new MemoryStream(ptrData, 0, (int)size));
        }

        private void GetPicWay2_Click(object sender, EventArgs e)
        {
            string s = "dll依赖的opencv版本为2.4.12的时候用该方法，其他方法不行";
            MessageBox.Show(s);
            //int width, height, step;
            //IntPtr dst = CSharpGetOpencvPicFromDll_Way2(out width, out height, out step);
            //Bitmap img = new Bitmap(width, height, step, System.Drawing.Imaging.PixelFormat.Format24bppRgb, dst);
            //pictureBox1.Image = img;
        }
    }
}
