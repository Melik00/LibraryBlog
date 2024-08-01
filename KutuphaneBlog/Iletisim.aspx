<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="KutuphaneBlog.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <!--/header-->
        <div class="contact-content">
            <div class="container">
                <div class="contact-info">
                    <h2>İletişim</h2>
                    <p>Kütüphane Blog Sayfamızda bulunan kitap ve dergilere eklemek istedikleriniz için ya da yorumlarda yaşayacağınız problemler konusuda buradan bizlere mesaj gönderebilirsiniz. Mesaj gönderme sırasında mutlaka mail adresinizi doğru bir şekilde yazın ki sizlere geri dönüş yapabilelim.</p>
                </div>
                <div class="contact-details">
                    <form runat="server">
                        <asp:TextBox ID="TextBox1" runat="server" placeholder="Ad Soyad" required=""></asp:TextBox>
                        <asp:TextBox ID="TextBox2" runat="server" placeholder="Mail" required=""></asp:TextBox>
                        <asp:TextBox ID="TextBox3" runat="server" placeholder="Telefon" required=""></asp:TextBox>
                        <asp:TextBox ID="TextBox4" runat="server" placeholder="Konu" required=""></asp:TextBox>
                        <asp:TextBox ID="TextBox5" runat="server" placeholder="Mesajınız..." required="" TextMode="MultiLine" Height="100"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="Gönder" OnClick="Button1_Click" />
                    </form>
                </div>
                <div class="contact-details">
                   <div style="max-width:100%;list-style:none; transition: none;overflow:hidden;width:600px;height:300px;"><div id="display-google-map" style="height:100%; width:100%;max-width:100%;"><iframe style="height:100%;width:100%;border:0;" frameborder="0" src="https://www.google.com/maps/embed/v1/place?q=Bursa&key=AIzaSyBFw0Qbyq9zTFTd-tUY6dZWTgaQzuU17R8"></iframe></div><a class="my-codefor-googlemap" href="https://www.bootstrapskins.com/themes" id="get-data-for-map">premium bootstrap themes</a><style>#display-google-map img{max-height:none;max-width:none!important;background:none!important;}</style></div>
                    <div class="clearfix"></div>
                </div>
            </div>
        </div>
</asp:Content>
