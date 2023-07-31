import{_ as a,M as c,p as d,q as t,R as e,t as r,N as n,V as s,a1 as h}from"./framework-c4f3d865.js";const i={},l=e("h1",{id:"lighttheme",tabindex:"-1"},[e("a",{class:"header-anchor",href:"#lighttheme","aria-hidden":"true"},"#"),r(" LightTheme")],-1),u=e("p",null,"Light theme for ReCaptcha control.",-1),p=e("strong",null,"Type:",-1),g=e("br",null,null,-1),b=e("strong",null,"Namespace:",-1),k=e("br",null,null,-1),f=e("strong",null,"Assembly:",-1),m=e("br",null,null,-1),x=e("strong",null,"Inherits from:",-1),B=h(`<div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">class</span> <span class="token class-name">LightTheme</span> <span class="token punctuation">:</span> <span class="token type-list"><span class="token class-name">ITheme</span></span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div></div></div><h2 id="constructors" tabindex="-1"><a class="header-anchor" href="#constructors" aria-hidden="true">#</a> Constructors</h2><p>Creates a new LightTheme.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token function">LightTheme</span><span class="token punctuation">(</span><span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div></div></div><h2 id="properties" tabindex="-1"><a class="header-anchor" href="#properties" aria-hidden="true">#</a> Properties</h2><h3 id="background" tabindex="-1"><a class="header-anchor" href="#background" aria-hidden="true">#</a> Background</h3><p>The main backhround color.</p><p><strong>Type</strong>: <code>Brush</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>new SolidColorBrush(Color.FromArgb(255, 249, 249, 249))</code></p><h3 id="border" tabindex="-1"><a class="header-anchor" href="#border" aria-hidden="true">#</a> Border</h3><p>The main border color.</p><p><strong>Type</strong>: <code>Brush</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>new SolidColorBrush(Color.FromArgb(255, 211, 211, 211))</code></p><h3 id="foreground" tabindex="-1"><a class="header-anchor" href="#foreground" aria-hidden="true">#</a> Foreground</h3><p>The main foreground color.</p><p><strong>Type</strong>: <code>Brush</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>new SolidColorBrush(Color.FromArgb(255, 0, 0, 0))</code></p><h3 id="foregroundsecondary" tabindex="-1"><a class="header-anchor" href="#foregroundsecondary" aria-hidden="true">#</a> ForegroundSecondary</h3><p>The secondary foreground color.</p><p><strong>Type</strong>: <code>Brush</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>new SolidColorBrush(Color.FromArgb(255, 85, 85, 85))</code></p><h3 id="error" tabindex="-1"><a class="header-anchor" href="#error" aria-hidden="true">#</a> Error</h3><p>The error message color.</p><p><strong>Type</strong>: <code>Brush</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>new SolidColorBrush(Color.FromArgb(255, 255, 0, 0))</code></p><h3 id="checkboxbackground" tabindex="-1"><a class="header-anchor" href="#checkboxbackground" aria-hidden="true">#</a> CheckBoxBackground</h3><p>The checkbox background color.</p><p><strong>Type</strong>: <code>Brush</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>new SolidColorBrush(Color.FromArgb(255, 255, 255, 255))</code></p><h3 id="checkboxbackgroundhover" tabindex="-1"><a class="header-anchor" href="#checkboxbackgroundhover" aria-hidden="true">#</a> CheckBoxBackgroundHover</h3><p>The checkbox background color when hovered.</p><p><strong>Type</strong>: <code>Brush</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>new SolidColorBrush(Color.FromArgb(255, 255, 255, 255))</code></p><h3 id="checkboxbackgroundpressed" tabindex="-1"><a class="header-anchor" href="#checkboxbackgroundpressed" aria-hidden="true">#</a> CheckBoxBackgroundPressed</h3><p>The checkbox background color when pressed.</p><p><strong>Type</strong>: <code>Brush</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>new SolidColorBrush(Color.FromArgb(255, 235, 235, 235))</code></p><h3 id="checkboxborder" tabindex="-1"><a class="header-anchor" href="#checkboxborder" aria-hidden="true">#</a> CheckBoxBorder</h3><p>The checkbox border color.</p><p><strong>Type</strong>: <code>Brush</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>new SolidColorBrush(Color.FromArgb(255, 211, 211, 211))</code></p><h3 id="checkboxborderhover" tabindex="-1"><a class="header-anchor" href="#checkboxborderhover" aria-hidden="true">#</a> CheckBoxBorderHover</h3><p>The checkbox border color when hovered.</p><p><strong>Type</strong>: <code>Brush</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>new SolidColorBrush(Color.FromArgb(255, 178, 178, 178))</code></p><h3 id="checkboxborderpressed" tabindex="-1"><a class="header-anchor" href="#checkboxborderpressed" aria-hidden="true">#</a> CheckBoxBorderPressed</h3><p>The checkbox border color when pressed.</p><p><strong>Type</strong>: <code>Brush</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>new SolidColorBrush(Color.FromArgb(255, 193, 193, 193))</code></p><h3 id="checkboxspinner" tabindex="-1"><a class="header-anchor" href="#checkboxspinner" aria-hidden="true">#</a> CheckBoxSpinner</h3><p>The checkbox loading spinner color.</p><p><strong>Type</strong>: <code>Brush</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>new SolidColorBrush(Color.FromArgb(255, 78, 144, 245))</code></p><h3 id="checkboxcheckmark" tabindex="-1"><a class="header-anchor" href="#checkboxcheckmark" aria-hidden="true">#</a> CheckBoxCheckmark</h3><p>The checkbox checkmark color.</p><p><strong>Type</strong>: <code>Brush</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>new SolidColorBrush(Color.FromArgb(255, 0, 158, 66))</code></p>`,44);function C(_,T){const o=c("RouterLink");return d(),t("div",null,[l,u,e("p",null,[p,r(" Class "),g,b,r(),n(o,{to:"/reference/recaptcha.desktop.winui/ui/themes/"},{default:s(()=>[r("ReCaptcha.Desktop.WinUI.UI.Themes")]),_:1}),k,f,r(),n(o,{to:"/reference/recaptcha.desktop.winui/"},{default:s(()=>[r("ReCaptcha.Desktop.WinUI")]),_:1}),m,x,r(),n(o,{to:"/reference/recaptcha.desktop.winui/ui/themes/interfaces/itheme.html"},{default:s(()=>[r("ITheme")]),_:1})]),B])}const v=a(i,[["render",C],["__file","lighttheme.html.vue"]]);export{v as default};
