using System;
using System.Collections;
using System.IO;
using TwinCAT.Ads;

namespace TestA
{
    class Program
    {
        static ArrayList notifyHdls = new ArrayList();
        static AdsStream dataStream = new AdsStream(16);
        static BinaryReader binRead = new BinaryReader(dataStream, System.Text.Encoding.ASCII);

        static void Main(string[] args)
        {
            TcAdsClient client = new TcAdsClient();
            client.Connect("192.168.0.112.1.1", 851);  //Establish ADS communication connection

            string varName = "MAIN.iTest";
            string varNameLr = "MAIN.lrTest";

            //Read according to the variable name 
            var val = (Int16)client.ReadSymbol(varName, typeof(Int16), true);
            Console.WriteLine( $ "MAIN.iTest: {val}");

            //Read 
            // var based on the variable 
            varHdl = client.CreateVariableHandle(varName);
            val = (Int16)client.ReadAny(varHdl, typeof(Int16));

            var varInfo = client.ReadSymbolInfo(varName);  //Get variable information 
            Console.WriteLine( $ "group: {varInfo.IndexGroup},offset: {varInfo.IndexOffset}");

            //Read through the stream according to the variable Group+Offset 
            var adsStream = new AdsStream(sizeof(Int16));
            client.Read((UInt32)varInfo.IndexGroup, (UInt32)varInfo.IndexOffset, adsStream);
            BinaryReader binReader = new BinaryReader(adsStream);
            Console.WriteLine($"-MAIN.iTest: {binReader.ReadInt16()}");

            //Read the string 
            //string according to the variable name 
            string sVal = client.ReadSymbol("MAIN.sTestId", typeof(string), true).ToString();
            Console.WriteLine( $ "MAIN.sTestId:{sVal}");

            //Read the array 
            Int16[] arrTests = (Int16[])client.ReadSymbol("MAIN.arrTests", typeof(Int16[]), true) according to the variable name;
            Console.WriteLine( $ "MAIN.arrTests:{string .Join(" - ", arrTests)}");

            //Read the structure according to the variable name 
            Cmd c = (Cmd)client.ReadSymbol("MAIN.sCmd", typeof(Cmd), true);
            Console.WriteLine( $ "MAIN.sCmd: {c.done},{ c.iLastCaller},{c.udExeCnt}");

            //Write the 
            //client according to the variable name 
            client.WriteSymbol(varName, 100, true);

            //Write to the 
            //client according to the variable handle . 
            client.WriteAny(varHdl, (Int16)200);

            //Write through the stream according to the handle 
            var adsStreamW = new AdsStream(sizeof(Int16));
            BinaryWriter binWriter = new BinaryWriter(adsStreamW);
            binWriter.Write((Int16)3);
            client.Write(varHdl, adsStreamW);

            //Write the string 
            //client according to the variable name 
            client.WriteSymbol("MAIN.sTestId", "ok", true);

            //Write the array according to the variable name, it will overwrite the entire array 
            Int16[] arrTestsW = new Int16[] { 9, 8, 7 };
            client.WriteSymbol("MAIN.arrTests", arrTestsW, true);

            //Write the structure 
            Cmd according to the variable name cw = new Cmd();
            cw.Done = true;
            cw.ILastCaller = 100;
            client.WriteSymbol("MAIN.sCmd", cw, true);

            //Event-driven read 
            notifyHdls.Add(client.AddDeviceNotification(varName, dataStream, AdsTransMode.OnChange, 500, 0, varName));
            notifyHdls.Add(client.AddDeviceNotification(varNameLr, dataStream, AdsTransMode.OnChange, 500, 0, varNameLr));
            client.AdsNotification + = new AdsNotificationEventHandler(AdsNotificationHandler);

            //Multi-threaded version//
            notifyHdls.Add(client.AddDeviceNotificationEx(varName, AdsTransMode.OnChange, 500, 0, varName, typeof(Int16)));
            //notifyHdls.Add(client.AddDeviceNotificationEx(varNameLr, AdsTransMode.OnChange, 500, 0, varNameLr, typeof(Double))); 
            //client.AdsNotificationEx += new AdsNotificationExEventHandler(AdsNotificationExHandler);

            Console.ReadLine();
            foreach (int hdl in notifyHdls)
            {
                client.DeleteDeviceNotification(hdl);
            }
            client.DeleteVariableHandle(varHdl);
            notifyHdls.Clear();
            client.Close();
        }

        static void AdsNotificationHandler(object sender, AdsNotificationEventArgs e)
        {
            DateTime time = DateTime.FromFileTime(e.TimeStamp);
            e.DataStream.Position = e.Offset;

            if (e.NotificationHandle == (int)notifyHdls[0])
                Console.WriteLine(binRead.ReadInt16().ToString() + e.UserData);
            else if (e.NotificationHandle == (int)notifyHdls[1])
                Console.WriteLine(binRead.ReadDouble().ToString() + e.UserData);
            else
                ;
        }

        static void AdsNotificationExHandler(object sender, AdsNotificationExEventArgs e)
        {
            string userData = (string)e.UserData;
            Type type = e.Value.GetType();
            Console.WriteLine( $ "TransId: {e.UserData}, {e.Value }");

            switch (userData)
            {
                case "MAIN.iTest":
                    //todo 
                    break;
                case "MAIN.lrTest":
                    //todo 
                    break;
                default:
                    break;
            }
        }
    }
}