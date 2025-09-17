using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace asdf
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int[] srnd = new int[5];
            //for(int i =0; i<srnd.Length; i++)
            //{
            //    srnd[i] = rnd.Next(90);
            //}
            //MyHelper.FindMinNum(srnd);

            //string abc = Console.ReadLine();
            //MyHelper.CountUpperCaseLetters(abc);


            Achievemnent ach = new Achievemnent("돌덩어리", "돌 줍기 500회", 500);
            Achievemnent ach1 = new Achievemnent("이제 정말 완전히 준비가 됐는걸", "하드 보스 처치 1회", 1);
            Achievemnent ach2= new Achievemnent("너흰 아직 준비가 안됐다", "보스에서 실패한 횟수", 300);
            Achievemnent ach3= new Achievemnent("다들 모여!", "마이룸에 초대 횟수", 1000);

            ach.Addprogress(480);
            ach.DisPlayInfo();
            ach1.Addprogress(2);
            ach1.DisPlayInfo();
            ach2.Addprogress(64);
            ach2.DisPlayInfo();
            ach3.Addprogress(1060);
            ach3.DisPlayInfo();

            Achievemnent.DisplaySummary();
        }
    }
}
