<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="contulmeu.aspx.vb" Inherits="IPGame.WebForm2" %>

<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>
<html xmlns='http://www.w3.org/1999/xhtml' xml:lang='ro' lang='ro'>
<head>
<title>Razboiul Robotilor - Echipa 13 - Contul meu</title>
<meta name='keywords' content='roboti, razboi, razboiul robotilor' />
<meta name='description' content='Razboiul Robotilor este un joc de societate realizat de: Alin Musat, Cristian Epure, Bogdan Olaru, Sorin Miroiu si Catalin Marinescu.' />
<meta name='copyright' content='Echipa 13 @ Facultatea de Matematica si Informatica - Universitatea din Bucuresti ' />
<meta http-equiv='Content-Language' content='ro' />
<meta http-equiv='Content-Type' content='text/html; charset=UTF-8' />
<meta name='googlebot' content='index, follow' />
<meta name='robots' content='index, follow' />
<meta name='revisit-after' content='7 days' />
<link href='css/stil.css' rel='stylesheet' type='text/css' />
</head>

<body>
<div id="banner">
     <img src="imagini/banner.png" alt="Razboiul Robotilor" />
   </div><!-- / banner -->
<div id="continut">

  <div id="parteaDeSus">
   <div id="meniuContainer">
    <ul class='meniu' rel="sam1">
      <li><a href="index.aspx">Home</a></li>
      <li class="activ"><a href="contulmeu.aspx">Contul meu</a></li>
      <li><a href="joaca.aspx">Joaca</a></li>
      <li><a href="clasament.aspx">Clasament</a></li>
      <li><a href="despre.aspx">Despre joc</a></li>
    </ul>
   </div> <!-- / meniuContainer -->
   
   <div id="logare">
   <!-- // user nelogat -->
    <form id="form1" runat="server">
    <div class='userparola'>
        
    <asp:Label ID="Usr" runat="server" CssClass="utilizator" Text="Utilizator:"></asp:Label> <asp:TextBox ID="Utilizator" cssclass="campDeDate" runat="server"></asp:TextBox>
      <asp:Label ID="Log1" cssclass="userlogat" runat="server" Text="Label" Visible=False>Bine ai revenit, <a href="#" title="link catre profil">Cristi</a>!</asp:Label>
        
   <br />
        <asp:Label ID="Pw" runat="server" CssClass="parola" Text="Label">Parola:</asp:Label> 
        <asp:TextBox ID="Password" cssclass="campDeDate" runat="server" TextMode="Password"></asp:TextBox>
         <asp:Label ID="Log2" runat="server" CssClass="statisticaSus" Text="Label" Visible="False">Loc ocupat in clasament: 1</asp:Label>

 <br />
  <asp:Label ID="Log3" runat="server" CssClass="statisticaSus" Text="Label" Visible="False">Numar puncte obtinute: 1000</asp:Label>
   <asp:Label ID="cont" runat="server" CssClass="nuaicont" Text="Label">Nu ai cont? <a href="cont-nou.aspx">Inregistreaza-te acum!</a></asp:Label>     
  
 
    </div><!-- / userparola -->

  
   <asp:Button ID="Button1" Text="Login" runat="server" CssClass="login" />
           
  <!-- user logat -->
 <!--
 <span class="userLogat">Bine ai revenit, <a href="#" title="link catre profil">Cristi</a>!<br />
 <span class="statisticaSus">Loc ocupat in clasament: </span> 1<br />
  <span class="statisticaSus">Numar puncte obtinute: </span> 1000<br /> -->
       </div> <!-- / logare -->
       </div> <!-- / parteaDeSus -->
 
 
   
  
  
  
  
  <div id="parteaStanga">
       <div class="primaPagina">
          <h1 class='titluStanga'>Razboiul Robotilor - Contul Meu</h1>
          
          <!-- pentru user nelogat
          <p>Salut vizitatorule! Pentru a putea accesa informatiile de pe aceasta pagina este nevoie sa te loghezi!<br /> -->
          
          <!-- pentru user logat -->
          
           <asp:Image ID="Image1" ImageUrl="imagini/avatar/no-avatar.jpg" cssclass="avatar" runat="server" />
          <div class="informatiiUser">
            <span>User:</span> 
              <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Cristi" 
                  Visible="False"></asp:Label>&nbsp;<br />
            <span>Victorii:</span> <asp:Label ID="Label2" runat="server" ForeColor="White" 
                  Text="51" Visible="False"></asp:Label><br />
            <span>Infrangeri:</span> <asp:Label ID="Label3" runat="server" ForeColor="White" 
                  Text="7" Visible="False"></asp:Label><br />
            <span>Puncte:</span> <asp:Label ID="Label4" runat="server" ForeColor="White" 
                  Text="1000" Visible="False"></asp:Label><br />
            <span>Loc in clasament:</span> <asp:Label ID="Label5" runat="server" 
                  ForeColor="White" Text="1" Visible="False"></asp:Label><br />
          
          <h3 class="istoricRecent">Istoric Recent</h3>
       <ul>
        <li class="istoric">
            <span class="nr">#</span>
         <span class="adversar">Adversar</span>
         <span class="rezultat">Rezultat</span>
         <asp:Label ID="is01" cssclass="nr" runat="server" Text="1." Visible="false"></asp:Label>
            <asp:Label ID="is02" cssclass="adversar" runat="server" Text="Label" Visible="false"></asp:Label>
            <asp:Label ID="is03" cssclass="rezultat" runat="server" Text="Label" Visible="false"></asp:Label>  
             <asp:Label ID="is11" cssclass="nr" runat="server" Text="2." Visible="false"></asp:Label>
 <asp:Label ID="is12" cssclass="adversar" runat="server" Text="Label" Visible="false"></asp:Label>
 <asp:Label ID="is13" cssclass="rezultat" runat="server" Text="Label" Visible="false"></asp:Label>
 <asp:Label ID="is21" cssclass="nr" runat="server" Text="3." Visible="false"></asp:Label>
 <asp:Label ID="is22" cssclass="adversar" runat="server" Text="Label" Visible="false"></asp:Label>
 <asp:Label ID="is23" cssclass="rezultat" runat="server" Text="Label" Visible="false"></asp:Label>
 <asp:Label ID="is31" cssclass="nr" runat="server" Text="4." Visible="false"></asp:Label>
 <asp:Label ID="is32" cssclass="adversar" runat="server" Text="Label" Visible="false"></asp:Label>
 <asp:Label ID="is33" cssclass="rezultat" runat="server" Text="Label" Visible="false"></asp:Label>
 <asp:Label ID="is41" cssclass="nr" runat="server" Text="5." Visible="false"></asp:Label>
 <asp:Label ID="is42" cssclass="adversar" runat="server" Text="Label" Visible="false"></asp:Label>
 <asp:Label ID="is43" cssclass="rezultat" runat="server" Text="Label" Visible="false"></asp:Label>
 <asp:Label ID="is51" cssclass="nr" runat="server" Text="6." Visible="false"></asp:Label>
 <asp:Label ID="is52" cssclass="adversar" runat="server" Text="Label" Visible="false"></asp:Label>
 <asp:Label ID="is53" cssclass="rezultat" runat="server" Text="Label" Visible="false"></asp:Label>
 <asp:Label ID="is61" cssclass="nr" runat="server" Text="7." Visible="false"></asp:Label>
 <asp:Label ID="is62" cssclass="adversar" runat="server" Text="Label" Visible="false"></asp:Label>
      <asp:Label ID="is63" cssclass="rezultat" runat="server" Text="Label" Visible="false"></asp:Label>
 <asp:Label ID="is71" cssclass="nr" runat="server" Text="8." Visible="false"></asp:Label>
 <asp:Label ID="is72" cssclass="adversar" runat="server" Text="Label" Visible="false"></asp:Label>
  <asp:Label ID="is73" cssclass="rezultat" runat="server" Text="Label" Visible="false"></asp:Label>
 <asp:Label ID="is81" cssclass="nr" runat="server" Text="9." Visible="false"></asp:Label>
 <asp:Label ID="is82" cssclass="adversar" runat="server" Text="Label" Visible="false"></asp:Label>
    <asp:Label ID="is83" cssclass="rezultat" runat="server" Text="Label" Visible="false"></asp:Label>
 <asp:Label ID="is91" cssclass="nr" runat="server" Text="10." Visible="false"></asp:Label>
       <asp:Label ID="is92" cssclass="adversar" runat="server" Text="Label" Visible="false"></asp:Label>
             <asp:Label ID="is93" cssclass="rezultat" runat="server" Text="Label" Visible="false"></asp:Label>
            <asp:ListBox ID="ListBox1" runat="server" Visible="False"></asp:ListBox>
            <asp:ListBox ID="ListBox2" runat="server" Visible="False"></asp:ListBox>
        </li>
      </ul>
          </div>
          
           </form>
          
          
       
       
       </div><!-- / primaPagina -->
  </div><!-- / parteaStanga -->
  
  <div id="parteaDreapta">
   <div class="top10">
      <h2 class='titluDreapta'>Top 10 Jucători</h2>
      
      <ul>
        <li class="titluClasament">
            <asp:Label ID="Cmen11" runat="server" cssclass="nr" Text="Label">#</asp:Label>
         <asp:Label ID="Cmen12" runat="server" cssclass="nume" Text="Label">Jucător</asp:Label>
          <asp:Label ID="Cmen13" runat="server" cssclass="puncte" Text="Label">Puncte</asp:Label>
        </li>
          <li class='jucator'>
<asp:Label ID="Cmen111" runat="server" cssclass="nr" Text="Label">1.</asp:Label>
         <asp:Label ID="Cmen112" runat="server" cssclass="nume" Text="Label">Cristi</asp:Label>
          <asp:Label ID="Cmen113" runat="server" cssclass="puncte" Text="Label">1000</asp:Label>
             </li>
        <li class='jucator'>
         <asp:Label ID="Cmen21" runat="server" cssclass="nr" Text="Label">2.</asp:Label>
         <asp:Label ID="Cmen22" runat="server" cssclass="nume" Text="Label">Alin</asp:Label>
          <asp:Label ID="Cmen23" runat="server" cssclass="puncte" Text="Label">890</asp:Label>
         </li>
        <li class='jucator'>
       <asp:Label ID="Cmen31" runat="server" cssclass="nr" Text="3."></asp:Label>
         <asp:Label ID="Cmen32" runat="server" cssclass="nume" Text="Label">Catalin</asp:Label>
          <asp:Label ID="Cmen33" runat="server" cssclass="puncte" Text="Label">575</asp:Label>
         </li>
        <li class='jucator'>
<asp:Label ID="Cmen41" runat="server" cssclass="nr" Text="Label">4.</asp:Label>
         <asp:Label ID="Cmen42" runat="server" cssclass="nume" Text="Label">Bogdan</asp:Label>
          <asp:Label ID="Cmen43" runat="server" cssclass="puncte" Text="Label">482</asp:Label>
      </li>
        <li class='jucator'>
   <asp:Label ID="Cmen51" runat="server" cssclass="nr" Text="Label">5.</asp:Label>
         <asp:Label ID="Cmen52" runat="server" cssclass="nume" Text="Label">Mihai</asp:Label>
          <asp:Label ID="Cmen53" runat="server" cssclass="puncte" Text="Label">392</asp:Label>
            </li>
        <li class='jucator'>
   <asp:Label ID="Cmen61" runat="server" cssclass="nr" Text="Label">6.</asp:Label>
         <asp:Label ID="Cmen62" runat="server" cssclass="nume" Text="Label">George</asp:Label>
          <asp:Label ID="Cmen63" runat="server" cssclass="puncte" Text="Label">370</asp:Label>
            </li>
        <li class='jucator'>
 <asp:Label ID="Cmen71" runat="server" cssclass="nr" Text="Label">7.</asp:Label>
         <asp:Label ID="Cmen72" runat="server" cssclass="nume" Text="Label">Cristina</asp:Label>
          <asp:Label ID="Cmen73" runat="server" cssclass="puncte" Text="Label">220</asp:Label>
              </li>
        <li class='jucator'>
 <asp:Label ID="Cmen81" runat="server" cssclass="nr" Text="Label">8.</asp:Label>
         <asp:Label ID="Cmen82" runat="server" cssclass="nume" Text="Label">Emil</asp:Label>
          <asp:Label ID="Cmen83" runat="server" cssclass="puncte" Text="Label">175</asp:Label>
              </li>
        <li class='jucator'>
  <asp:Label ID="Cmen91" runat="server" cssclass="nr" Text="Label">9.</asp:Label>
         <asp:Label ID="Cmen92" runat="server" cssclass="nume" Text="Label">Andrei</asp:Label>
          <asp:Label ID="Cmen93" runat="server" cssclass="puncte" Text="Label">90</asp:Label>
             </li>
        <li class='jucator'>
 <asp:Label ID="Cmen101" runat="server" cssclass="nr" Text="Label">10.</asp:Label>
         <asp:Label ID="Cmen102" runat="server" cssclass="nume" Text="Label">Sorin</asp:Label>
          <asp:Label ID="Cmen103" runat="server" cssclass="puncte" Text="Label">12</asp:Label>
              </li>
      
      </ul>
      <a href="Clasament.aspx">[vezi întregul clasament]</a>
    </div> <!-- / top10 -->
    
    <div class="noutati">
     <h2 class='titluDreapta'>Ştiri, Anunţuri &amp; Noutăţi</h2>
     <!-- de preferat stirile vor fi preluate din baza de date si nu introduse manual pe fiecare pagina :) -->
     <p><span class="data">01.01.2014</span> - La mulţi ani 2014!</p>
     <p><span class="data">27.12.2013</span> - La mulţi ani Ştefan şi în special Ştefania!</p>
     <p><span class="data">25.12.2013</span> - Crăciun fericit!</p>
     <p><span class="data">15.12.2013</span> - După realizarea mockup-ului s-a trecut la realizarea design-ului propriu-zis.</p>
     <p><span class="data">03.12.2013</span> - S-a început lucrul la joc, prin repartizarea sarcinilor membrilor echipei, de la cod la design.</p>
    
    </div> <!-- / noutati -->
    
    <div class="echipa">
     <h2 class='titluDreapta'>Echipa 13</h2>
     <p>
     <span class="developer">Alin Muşat</span> - Cloud Computing<br />
     <span class="developer">Cristian Epure</span> - Designer<br />
     <span class="developer">Bogdan Olaru</span> - Designer<br />
  <span class="developer">Cătălin Marinescu</span> - Baza de date<br />
     <span class="developer">Sorin Miroiu</span> - Coder<br />
     </p>
    
    </div> <!-- / echipa -->
    
  </div><!-- / parteaStanga -->
  
  <div class="curata">&nbsp;</div>
   <div id="parteaDeJos">
   Copyright &copy; Echipa 13
   </div>
</div> <!-- / continut -->

</body>
</html>