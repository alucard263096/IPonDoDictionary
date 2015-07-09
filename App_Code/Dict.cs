using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Dict
/// </summary>
public class Dict
{
	public Dict()
	{
		
        private void button3_Click(object sender, EventArgs e)
        {
            string str = "aar ae ai air aor ar are au aw ay ea ear eau ee eer ei eir en eo er ere eu eur ew ey ia iar ie ient ier iew io ion ior iou ir ire iu oa oar oe oi oir on oo oor ore ou ough our ow oy ua uar ue uer ui uou ur ure uu uy ya ye yer yi yo yr yre";
            string[] arr = str.Split(new string[]{" "},StringSplitOptions.RemoveEmptyEntries);
            arr = GetString(arr);
            arr = SortString(arr);
            List<string> sarr = arr.ToList();
            foreach (var item in "aeiou")
            {
                string sw = "ll ss nd nt lf st nk ng ed";
                string[] cc = sw.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var it in cc)
                {
                    sarr.Add(item+it);   
                }
            }
            arr = sarr.ToArray();

            //richTextBox1.Text = string.Join(",", arr);

            string zh = "b c d f g h j k l m n p q r s t v w x y z bl cl fl gl pl sl br cr dr fr gr pr tr sc sk sm sn sp st sw qu scr spr spl str squ shr thr ch sh th wh ph";

            string[] zcc = zh.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            zcc = GetString(zcc);
            zcc = SortString(zcc);

            string w = "zz ff ll ss mp nd ft lt nt lf st nk ng ck lk";

            string[] wtt = w.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            wtt = GetString(wtt);
            wtt = SortString(wtt);


            string m = "bl cr mp nc nd nt rm rs rt st btr bst ctr trm ldr ncl ncr nds ngr ntr rnm rtr spl str tst zpl ch ck dg gh lk sh th ph cc dd ff gg ll mm nn pp ss tt";
            string[] mff = m.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            mff = GetString(mff);
            mff = SortString(mff);

            StringBuilder sb = new StringBuilder();
            foreach (var fy in zcc)
            {
                foreach (var yy in arr)
                {
                    sb.AppendLine(string.Format("dict[\"{0}{1}\"] = \"\";", fy, yy));
                }
            }
            foreach (var item in wtt)
            {
                sb.AppendLine(string.Format("dict[\"{0}\"] = \"\";", item));
            }
            foreach (var item in mff)
            {
                sb.AppendLine(string.Format("dict[\"{0}\"] = \"\";", item));
            }
            foreach (var item in arr)
            {
                sb.AppendLine(string.Format("dict[\"{0}\"] = \"\";", item));
            }
            richTextBox1.Text = sb.ToString();
        }

        private static string[] SortString(string[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = i+1; j < values.Length; j++)
                {
                    string a = values[i];
                    string b = values[j];
                    string t="";
                    if (a.Length != b.Length)
                    {
                        if (b.Length > a.Length)
                        {
                            t = a;
                            a = b;
                            b = t;
                        }
                    }
                    else
                    {
                        if (b.CompareTo(a)<0)
                        {
                            t = a;
                            a = b;
                            b = t;
                        }
                    }
                    values[i] = a;
                    values[j] = b;
                }
            }
            return values;
        }

        public static string[] GetString(string[] values)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < values.Length; i++)//遍历数组成员 
            {
                if (list.IndexOf(values[i].ToLower()) == -1)//对每个成员做一次新数组查询如果没有相等的则加到新数组 
                    list.Add(values[i]);

            }
            return list.ToArray();
        }
	}
}