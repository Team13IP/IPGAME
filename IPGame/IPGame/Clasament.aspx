<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Clasament.aspx.vb" Inherits="IPGame.Clasament" %>

<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>
<html xmlns='http://www.w3.org/1999/xhtml' xml:lang='ro' lang='ro'>
<head>
<title>Razboiul Robotilor - Echipa 13 - Clasament</title>
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
      <li><a href="contulmeu.aspx">Contul meu</a></li>
      <li><a href="joaca.aspx">Joaca</a></li>
      <li class="activ"><a href="Clasament.aspx">Clasament</a></li>
      <li><a href="despre.aspx">Despre joc</a></li>
    </ul>
   </div> <!-- / meniuContainer -->
   
   <div id="logare">
   <!-- // user nelogat -->
       <form id="form1" runat="server">
    <div class='userparola'>
        
    <asp:Label ID="Usr" runat="server" CssClass="utilizator" Text="Utilizator:"></asp:Label> <asp:TextBox ID="Utilizator" cssclass="campDeDate" runat="server"></asp:TextBox>
      <asp:Label ID="Log1" cssclass="userlogat" runat="server" Text="Label" Visible="false">Bine ai revenit, <a href="#" title="link catre profil">Cristi</a>!</asp:Label>
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
     </div> <!-- / logare -->
  
       </div> <!-- / parteaDeSus -->
 
 
   
  
  
  
  
  <div id="parteaStanga">
       <div class="primaPagina">
          <h1 class='titluStanga'>Razboiul Robotilor - Clasament</h1>
           <div class="clasament">  
      <ul>
        <li class="titluClasament">
         <span class="nr">#</span>
         <span class="nume">Jucător</span>
         <span class="victorii">Victorii</span>
         <span class="infrangeri">Infrangeri</span>
         <span class="puncte">Puncte</span>
        </li>
        <li class='jucator'>
            <asp:Label ID="cm01" runat="server" CssClass="nr">1.</asp:Label>
           <asp:Label ID="cm02" runat="server" CssClass="nume">Cristi</asp:Label>
       <asp:Label ID="cm03" runat="server" CssClass="victorii">51</asp:Label>
       <asp:Label ID="cm04" runat="server" CssClass="infrangeri">7</asp:Label>
        <asp:Label ID="cm05" runat="server" CssClass="puncte">1000</asp:Label>
      </li>
        <li class='jucator'>
         <asp:Label ID="cm11" runat="server" CssClass="nr">2.</asp:Label>
        <asp:Label ID="cm12" runat="server" CssClass="nume">Alin</asp:Label>
       <asp:Label ID="cm13" runat="server" CssClass="victorii">48</asp:Label>
       <asp:Label ID="cm14" runat="server" CssClass="infrangeri">17</asp:Label>
        <asp:Label ID="cm15" runat="server" CssClass="puncte">890</asp:Label>
      </li>
        <li class='jucator'>
 <asp:Label ID="cm21" runat="server" CssClass="nr">3.</asp:Label>
        <asp:Label ID="cm22" runat="server" CssClass="nume">Catalin</asp:Label>
       <asp:Label ID="cm23" runat="server" CssClass="victorii">39</asp:Label>
       <asp:Label ID="cm24" runat="server" CssClass="infrangeri">23</asp:Label>
        <asp:Label ID="cm25" runat="server" CssClass="puncte">575</asp:Label>
    </li>
        <li class='jucator'>
      <asp:Label ID="cm31" runat="server" CssClass="nr">4.</asp:Label>
        <asp:Label ID="cm32" runat="server" CssClass="nume">Bogdan</asp:Label>
       <asp:Label ID="cm33" runat="server" CssClass="victorii">32</asp:Label>
       <asp:Label ID="cm34" runat="server" CssClass="infrangeri">20</asp:Label>
        <asp:Label ID="cm35" runat="server" CssClass="puncte">482</asp:Label>
      </li>
        <li class='jucator'>
  <asp:Label ID="cm41" runat="server" CssClass="nr">5.</asp:Label>
        <asp:Label ID="cm42" runat="server" CssClass="nume">Mihai</asp:Label>
       <asp:Label ID="cm43" runat="server" CssClass="victorii">25</asp:Label>
       <asp:Label ID="cm44" runat="server" CssClass="infrangeri">38</asp:Label>
        <asp:Label ID="cm45" runat="server" CssClass="puncte">392</asp:Label>
   </li>
        <li class='jucator'>
           <asp:Label ID="cm51" runat="server" CssClass="nr">6.</asp:Label>
        <asp:Label ID="cm52" runat="server" CssClass="nume">George</asp:Label>
       <asp:Label ID="cm53" runat="server" CssClass="victorii">24</asp:Label>
       <asp:Label ID="cm54" runat="server" CssClass="infrangeri">41</asp:Label>
        <asp:Label ID="cm55" runat="server" CssClass="puncte">370</asp:Label>
        </li>
        <li class='jucator'>
  <asp:Label ID="cm61" runat="server" CssClass="nr">7.</asp:Label>
        <asp:Label ID="cm62" runat="server" CssClass="nume">Cristina</asp:Label>
       <asp:Label ID="cm63" runat="server" CssClass="victorii">18</asp:Label>
       <asp:Label ID="cm64" runat="server" CssClass="infrangeri">33</asp:Label>
        <asp:Label ID="cm65" runat="server" CssClass="puncte">220</asp:Label>
        </li>
        <li class='jucator'>
  <asp:Label ID="cm71" runat="server" CssClass="nr">8.</asp:Label>
        <asp:Label ID="cm72" runat="server" CssClass="nume">Emil</asp:Label>
       <asp:Label ID="cm73" runat="server" CssClass="victorii">17</asp:Label>
       <asp:Label ID="cm74" runat="server" CssClass="infrangeri">53</asp:Label>
        <asp:Label ID="cm75" runat="server" CssClass="puncte">175</asp:Label>
         </li>
        <li class='jucator'>
  <asp:Label ID="cm81" runat="server" CssClass="nr">9.</asp:Label>
        <asp:Label ID="cm82" runat="server" CssClass="nume">Andrei</asp:Label>
       <asp:Label ID="cm83" runat="server" CssClass="victorii">7</asp:Label>
       <asp:Label ID="cm84" runat="server" CssClass="infrangeri">23</asp:Label>
        <asp:Label ID="cm85" runat="server" CssClass="puncte">90</asp:Label>
        </li>
        <li class='jucator'>
  <asp:Label ID="cm91" runat="server" CssClass="nr">10.</asp:Label>
        <asp:Label ID="cm92" runat="server" CssClass="nume">Sorin</asp:Label>
       <asp:Label ID="cm93" runat="server" CssClass="victorii">2</asp:Label>
       <asp:Label ID="cm94" runat="server" CssClass="infrangeri">9</asp:Label>
        <asp:Label ID="cm95" runat="server" CssClass="puncte">12</asp:Label>
         </li>
      </ul>
      <div class="paginatie">
         <asp:LinkButton ID="LinkButton1" runat="server" 
              PostBackUrl="#">Previous</asp:LinkButton>
&nbsp;| <asp:LinkButton ID="LinkButton2" runat="server" 
              PostBackUrl="#">Next</asp:LinkButton>   
          <asp:ListBox ID="ListBox1" runat="server" Visible="False"></asp:ListBox>
          <asp:ListBox ID="ListBox2" runat="server" Visible="False"></asp:ListBox>
          <asp:ListBox ID="ListBox3" runat="server" Visible="False"></asp:ListBox>
          <asp:ListBox ID="ListBox4" runat="server" Visible="False"></asp:ListBox>
          <asp:ListBox ID="ListBox5" runat="server" Visible="False"></asp:ListBox>
               </div>
    </div> <!-- / top10 -->
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
       <asp:Label ID="Cmen31" runat="server" cssclass="nr" Text="Label">3.</asp:Label>
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