using DevExpress.Data.Extensions;
using DevExpress.Drawing;
using DevExpress.XtraReports.UI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DocumentViewerApp.Services
{
    public class FontCollectorService
    {
        string apiKey = "your-api-key";
        string fontApiUrl = "https://www.googleapis.com/webfonts/v1/webfonts/?family=";

        async Task<byte[]> LoadFontFromGoogle(string fontName)
        {
            string fontUrl = $"{fontApiUrl}{fontName}&key={apiKey}";
            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response = await client.GetAsync(fontUrl);
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine(response.StatusCode);
                    return null;
                }
                string content = await response.Content.ReadAsStringAsync();
                MyFontList webfontList = JsonConvert.DeserializeObject<MyFontList>(content);
                return await LoadFontFile(webfontList.Items[0].Files.regular);
            }

        }
        async Task<byte[]> LoadFontFile(string fontUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(fontUrl);
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine(response.StatusCode);
                    return null;
                }
                using (MemoryStream fileStream = new MemoryStream())
                {
                    await response.Content.CopyToAsync(fileStream);
                    //byte[] result = new byte[fileStream.Length];
                    //fileStream.ToArray();
                    //fileStream.Write(result, 0, (int)fileStream.Length);
                    return fileStream.ToArray();
                }

            }
        }

        async Task SaveFontToDXFontRepository(string fontName)
        {
            byte[] fontData = await LoadFontFromGoogle(fontName);

            bool isDuplicate = CheckFontsForDuplicates(fontName);
            if (fontData != null && fontData.Length != 0 && isDuplicate == false)
                DXFontRepository.Instance.AddFont(fontData);
        }

        private bool CheckFontsForDuplicates(string fontName)
        {
            var fonts = DXFontRepository.Instance.GetFonts();
            return fonts.FindIndex(font => font.Name == fontName) != -1;
        }


        public async Task ProcessReport(XtraReport report)
        {
            foreach (XRControlStyle style in report.StyleSheet)
            {
                await SaveFontToDXFontRepository(style.Font.Name);

            }
            foreach (XRControl reportControl in report.AllControls<XRControl>())
            {
                await SaveFontToDXFontRepository(reportControl.Font.Name);
            }

        }
    }
    class MyFont
    {
        public string Family { get; set; }
        public string Menu { get; set; }
        public Files Files { get; set; }
    }

    class MyFontList
    {
        public List<MyFont> Items { get; set; }
    }
    class Files
    {
        public string regular { get; set; }
    }
}

