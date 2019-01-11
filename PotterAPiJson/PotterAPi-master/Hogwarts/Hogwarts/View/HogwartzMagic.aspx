<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HogwartzMagic.aspx.cs" Inherits="Hogwarts.View.FindYourHouse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" id="HogwartzUni">
<head runat="server">
    <title>Welcome to Hogwartz</title>     
    <style>
        body {
                background-image: url(./3840x1200.jpg);            
                background-size: 100%;
                background-repeat: no-repeat;
                background-attachment: fixed;
             }

        
        table{
            color:white;
            float:right;
            text-align :left;
        }

      
       .img{
            height :400px;
            width :600px;
}
    </style>
</head>
<body runat="server" id="HogwartzBody" >
           
      <!--<script type="text/javascript">
              function doHide(){
		            document.getElementById("HouseImage1").style.display = "none" ;
	           }

	        function hideImage(){
		//  5000 = 5 seconds
		            setTimeout( "doHide()", 5000 ) ;
	            }
       </script>-->
    
   
    <form id="form1" runat="server">
        <asp:Button ID="GetHouse" runat="server" OnClick="GetHouse_Click" Text="Let's see which house you get" CssClass="getHouse" />
        <asp:Image ID="HouseImage1" runat="server" AlternateText="Image text" ImageAlign="left"  ImageUrl="https://media.giphy.com/media/N3tNKBmQR3K2k/giphy.gif" alt ="HouseImage" CssClass="img"/>
         <asp:Button ID="GetSpells" runat="server" Text="You have to know all spells in Hogwartz" OnClick="GetSpells_Click" CssClass="centerButton"/>
     </form>
      
    <div>
            <asp:Repeater id="HorwartzSpells" runat="server">
                <HeaderTemplate>
                    <table class="table">
                    <thead>
                    <tr>
                        <th>Spell Name</th>
                        <th>Spell effect</th>
                    </tr>
                    </thead>
                </HeaderTemplate>

                <ItemTemplate>
                    <tr>
                        <td>
                        <%# DataBinder.Eval(Container, "DataItem.Spell")%>
                        </td>
                        <td>
                        <%# DataBinder.Eval(Container, "DataItem.Effect")%>
                        </td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </div>

</body>
</html>
