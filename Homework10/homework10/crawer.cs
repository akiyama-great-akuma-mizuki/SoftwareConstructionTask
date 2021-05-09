using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;

namespace homework9
{
    public class crawer
    {
        public delegate void statusChanged(String args);
        public event statusChanged CrawerStatusChanged;

        private Hashtable urls = new Hashtable();
        private int count = 0;
        private string Webfiliter = null;
        public string startUrl = "http://www.baidu.com/";
        
        public crawer(String startUrl)
        {
            this.startUrl = startUrl;
            urls.Add(startUrl, false);
        }
        public crawer(String startUrl,String filiter)
        {
            this.startUrl = startUrl;
            urls.Add(startUrl, false);
            this.Webfiliter = filiter;
        }
        public crawer() 
        {
            urls.Add(startUrl, false);
        }
        //爬取全部页面
        public void CrawlAll()
        {
            CrawerStatusChanged("crawer started!!"+ System.Environment.NewLine);
            while (true)
            {
                string current = null;
                foreach(string cru in urls.Keys)
                {
                    if ((bool)urls[cru])
                        continue;
                    current = cru;
                }
                if (current == null || count > 20)
                    break;
                if (Webfiliter != null && !Regex.IsMatch(current, Webfiliter))
                    break;
                CrawerStatusChanged("爬取" + current + "页面!"+ System.Environment.NewLine);
                string html = DownLoad(current);

                urls[current] = true;
                count++;

                Prase(html);
            }
            CrawerStatusChanged("爬取结束！"+ System.Environment.NewLine);

        }

        //爬取指定页面
        public void CrawlSingle()
        {
            CrawerStatusChanged("crawer started!!"+ System.Environment.NewLine);
            CrawerStatusChanged("爬取" + startUrl + "页面!"+ System.Environment.NewLine);
            string html = DownLoad(startUrl);
            CrawerStatusChanged("爬取结束！"+System.Environment.NewLine);
        }

        //解析
        public void Prase(String html)
        {
            if (html == null)
                return;
            string strref = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection mat = new Regex(strref).Matches(html);

            foreach(Match match in mat)
            {
                strref = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', ' ', '>');
                if (strref.Length == 0)
                    continue;
                CrawerStatusChanged("解析到" + strref + System.Environment.NewLine);
                if (!Regex.IsMatch(strref, @"[a-zA-Z0-9]+\.(com|net|cn|org|edu|gov)"))
                {
                    if (strref.StartsWith("/"))
                    {
                        string temp = startUrl.Substring(7);//去掉http://
                        if (!temp.Contains('/'))                        
                            strref = startUrl + strref;
                        else
                        {
                            temp = temp.Substring(0,temp.IndexOf('/'));
                            strref = "http://" + temp + strref;

                        }
                    }
                    else if (strref.StartsWith("../"))
                    {
                        string temp = startUrl.Substring(7);//去掉http://、
                        if (!temp.Contains('/'))
                        {
                            CrawerStatusChanged("错误的url!" + System.Environment.NewLine);
                            return;
                        }
                        temp.Remove(temp.LastIndexOf('/'));
                        if (!temp.Contains('/'))
                        {
                            CrawerStatusChanged("错误的url!" + System.Environment.NewLine);
                            return;
                        }
                        else
                        {
                            temp = temp.Substring(0, temp.LastIndexOf('/'));
                            strref = "http://" + temp + strref.Remove(0, 2);
                        }
                    }
                    else if (strref.StartsWith("./"))
                    {
                        strref  = strref.Remove(0, 1);
                        String stUrl = startUrl;
                        stUrl.Remove(stUrl.LastIndexOf('/'));
                        strref = stUrl + strref;
                    }
                    else
                    {
                        String stUrl = startUrl;
                        stUrl =  stUrl.Remove(stUrl.LastIndexOf('/'));
                        strref = stUrl + strref;
                    }
                }
                if (urls[strref] == null)
                    urls[strref] = false;
            }
        }

        //下载
        public string DownLoad(String url)
        {
            try
            {
                WebClient webclient = new WebClient();
                webclient.Encoding = Encoding.UTF8;
                string html = webclient.DownloadString(url);

                string filename = System.AppDomain.CurrentDomain.BaseDirectory + count.ToString()+".txt";
                File.WriteAllText(filename, html, Encoding.UTF8);
                CrawerStatusChanged("html下载完成！已保存在"+filename+ System.Environment.NewLine);
                
                return html;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                CrawerStatusChanged("爬取失败"+e.Message+System.Environment.NewLine);
                return null;
            }
        }
        
    }
}
