import{_ as o,M as p,p as c,q as i,R as s,t as e,N as a,V as t,a1 as r}from"./framework-c4f3d865.js";const d={},l=s("h1",{id:"extentions",tabindex:"-1"},[s("a",{class:"header-anchor",href:"#extentions","aria-hidden":"true"},"#"),e(" Extentions")],-1),u=s("p",null,"Extension methods to create configurations easier.",-1),h=s("strong",null,"Type:",-1),k=s("br",null,null,-1),m=s("strong",null,"Namespace:",-1),g=s("br",null,null,-1),v=s("strong",null,"Assembly:",-1),b=r(`<div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">static</span> <span class="token keyword">class</span> <span class="token class-name">Extentions</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div></div></div><h2 id="methods" tabindex="-1"><a class="header-anchor" href="#methods" aria-hidden="true">#</a> Methods</h2><h3 id="asrecaptchaconfig" tabindex="-1"><a class="header-anchor" href="#asrecaptchaconfig" aria-hidden="true">#</a> AsReCaptchaConfig</h3><p>Creates a new ReCaptchaConfig.</p><p><strong>Returns:</strong> A new AsReCaptchaConfig.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">static</span> <span class="token return-type class-name">ReCaptchaConfig</span> <span class="token function">AsReCaptchaConfig</span><span class="token punctuation">(</span>
    <span class="token keyword">this</span> <span class="token class-name"><span class="token keyword">string</span></span> siteKey<span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">string</span></span> hostName<span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">string</span></span> language <span class="token operator">=</span> <span class="token string">&quot;en&quot;</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">string</span></span> tokenRecievedHtml <span class="token operator">=</span> <span class="token string">&quot;Token recieved: %token%&quot;</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">string</span></span> tokenRecievedHookedHtml <span class="token operator">=</span> <span class="token string">&quot;Token recieved and sent to application.&quot;</span><span class="token punctuation">,</span>
    <span class="token class-name">HttpServerConfig<span class="token punctuation">?</span></span> httpConfiguration <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><table><thead><tr><th>Parameter</th><th>Description</th></tr></thead><tbody><tr><td><code>this string</code> siteKey</td><td>The SiteKey for the Google reCAPTCHA service.</td></tr><tr><td><code>string</code> hostName</td><td>The name of the virtual host on which the reCAPTCHA is hosted. Should represent your application.</td></tr><tr><td><em><code>string</code> language</em></td><td>The language for the Google reCAPTCHA service.</td></tr><tr><td><em><code>string</code> tokenRecievedHtml</em></td><td>The HTML which gets displayed after the user verifed the reCAPTCHA. Use %token% to embed the token inside the message.</td></tr><tr><td><em><code>string</code> tokenRecievedHookedHtml</em></td><td>The HTML which gets displayed after the user verifed the reCAPTCHA and its hooked to the application. Use %token% to embed the token inside the message.</td></tr><tr><td><em><code>HttpServerConfig?</code> httpConfiguration</em></td><td>The configuration for the HttpServer.</td></tr></tbody></table><h3 id="aspopupconfig" tabindex="-1"><a class="header-anchor" href="#aspopupconfig" aria-hidden="true">#</a> AsPopupConfig</h3><p>Creates a new PopupConfig.</p><p><strong>Returns:</strong> A new PopupConfig.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">static</span> <span class="token return-type class-name">PopupConfig</span> <span class="token function">AsPopupConfig</span><span class="token punctuation">(</span>
    <span class="token keyword">this</span> <span class="token class-name"><span class="token keyword">string</span></span> title<span class="token punctuation">,</span>
    <span class="token class-name">ImageSource<span class="token punctuation">?</span></span> icon <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">bool</span></span> hasTitlebar <span class="token operator">=</span> <span class="token boolean">true</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">bool</span></span> isDraggable <span class="token operator">=</span> <span class="token boolean">false</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">bool</span></span> isDimmed <span class="token operator">=</span> <span class="token boolean">true</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">bool</span><span class="token punctuation">?</span></span> hasRoundedCorners <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">,</span>
    <span class="token class-name">PopupStartupLocation</span> startupLocation <span class="token operator">=</span> PopupStartupLocation<span class="token punctuation">.</span>CenterPrimary<span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">int</span></span> left <span class="token operator">=</span> <span class="token number">0</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">int</span></span> top <span class="token operator">=</span> <span class="token number">0</span><span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><table><thead><tr><th>Parameter</th><th>Description</th></tr></thead><tbody><tr><td><code>string</code> title</td><td>The title of the dialog (Only used when HasTitleBar is true).</td></tr><tr><td><em><code>ImageSource?</code> icon</em></td><td>The icon of the dialog (Only used when HasTitleBar is true).</td></tr><tr><td><em><code>bool</code> hasTitlebar</em></td><td>Wether the dialog has a TitleBar.</td></tr><tr><td><em><code>bool</code> isDraggable</em></td><td>Wether the dialog is draggable within the main window (Only used when HasTitleBar is true).</td></tr><tr><td><em><code>bool</code> isDimmed</em></td><td>Wether the dialog dims the main windows background.</td></tr><tr><td><em><code>bool?</code> hasRoundedCorners</em></td><td>Wether the window has rounded corners (If null the value is true on Windows 11 and false on Windows 10).</td></tr><tr><td><em><code>PopupStartupLocation</code> startupLocation</em></td><td>The startup location of the popup.</td></tr><tr><td><em><code>int</code> left</em></td><td>The left position of the window.</td></tr><tr><td><em><code>int</code> top</em></td><td>The top position of the window.</td></tr></tbody></table>`,12);function f(w,y){const n=p("RouterLink");return c(),i("div",null,[l,u,s("p",null,[h,e(" Class "),k,m,e(),a(n,{to:"/reference/recaptcha.desktop.uwp/configuration/"},{default:t(()=>[e("ReCaptcha.Desktop.UWP.Configuration")]),_:1}),g,v,e(),a(n,{to:"/reference/recaptcha.desktop.uwp/"},{default:t(()=>[e("ReCaptcha.Desktop.UWP")]),_:1})]),b])}const _=o(d,[["render",f],["__file","extentions.html.vue"]]);export{_ as default};