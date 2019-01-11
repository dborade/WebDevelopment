using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using unirest_net.http;
using Hogwarts.Model;
using Newtonsoft.Json;

namespace Hogwarts.View
{

    public partial class FindYourHouse : System.Web.UI.Page
    {
        string baseApi = "https://www.potterapi.com/v1";
        string sortingHat = "/sortingHat";
        string allSpells = "/spells?key=KeyOfAPI";
        string Uri;
        string Key = "$2a$10$PWa6tLSwFbkx8zh5MrBLo.AyPyVy7eyTsNny3IU8mqhtrekWoc19u";
        //public string bg = "http://starkovtattoo.spb.ru/images/300/DSC100331268.jpg";


        protected void Page_Load(object sender, EventArgs e)
        {
            HogwartzBody.Style["background-image"] = "http://starkovtattoo.spb.ru/images/300/DSC100331268.jpg";

        }

        protected void GetHouse_Click(object sender, EventArgs e)
        {
            HouseImage1.ImageUrl = "https://media.giphy.com/media/JDAVoX2QSjtWU/giphy.gif";
            //System.Threading.Thread.Sleep(2000);
            Uri = baseApi + sortingHat;
            String HName = ExecuteJsonGet(Uri).Replace("\"", "");
            //HouseName.Text = HName;
            HouseImage1.ImageUrl = GetHouseImage(HName);
        }

       
        protected void GetSpells_Click(object sender, EventArgs e)
        {

            var AllSpells = GiveSpells();
            HorwartzSpells.DataSource = AllSpells;
            HorwartzSpells.DataBind();
            

        }

       

        public List<HogwartzSpells> GiveSpells()
        {
            Uri = baseApi + allSpells.Replace("KeyOfAPI", Key);
            HttpResponse<string> jsonResponse = Unirest.get(Uri).asString();
            
            string myBody = jsonResponse.Body;
            List<HogwartzSpells> Hs = JsonConvert.DeserializeObject<List<HogwartzSpells>>(myBody);
            return Hs;
          
        }

        public string ExecuteJsonGet(string URI)
        {
            HttpResponse<string> jsonResponse = Unirest.get(URI).asString();
            
            string myBody = jsonResponse.Body;
            return myBody;
        }

       

        public string GetHouseImage(string HName)
        {

            switch (HName)
            {
                case "Slytherin":
                    return "https://66.media.tumblr.com/891558c3b39360a22ce2c8a938c61f7e/tumblr_nzzami5EWX1u0dx7qo1_250.gif";


                case "Gryffindor":
                    return "https://i.pinimg.com/originals/04/4a/a7/044aa71c47a5fc21608ae07ed142c2a7.gif";


                case "Ravenclaw":
                    return "https://i.gifer.com/AOzI.gif";

                case "Hufflepuff":
                    return "https://media.giphy.com/media/PMp40oEvNfKve/giphy.gif";

                default:
                  
                       return "https://i.gifer.com/AOzI.gif";

            }

        }
    }
}