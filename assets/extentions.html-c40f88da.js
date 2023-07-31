import{_ as o,M as c,p as i,q as d,R as n,t as s,N as a,V as t,a1 as p}from"./framework-c4f3d865.js";const r={},l=n("h1",{id:"extentions",tabindex:"-1"},[n("a",{class:"header-anchor",href:"#extentions","aria-hidden":"true"},"#"),s(" Extentions")],-1),u=n("p",null,"Extension methods to create configurations easier.",-1),h=n("strong",null,"Type:",-1),k=n("br",null,null,-1),m=n("strong",null,"Namespace:",-1),g=n("br",null,null,-1),w=n("strong",null,"Assembly:",-1),v=p(`<div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">static</span> <span class="token keyword">class</span> <span class="token class-name">Extentions</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div></div></div><h2 id="methods" tabindex="-1"><a class="header-anchor" href="#methods" aria-hidden="true">#</a> Methods</h2><h3 id="asrecaptchaconfig" tabindex="-1"><a class="header-anchor" href="#asrecaptchaconfig" aria-hidden="true">#</a> AsReCaptchaConfig</h3><p>Creates a new ReCaptchaConfig.</p><p><strong>Returns:</strong> A new AsReCaptchaConfig.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">static</span> <span class="token return-type class-name">ReCaptchaConfig</span> <span class="token function">AsReCaptchaConfig</span><span class="token punctuation">(</span>
    <span class="token keyword">this</span> <span class="token class-name"><span class="token keyword">string</span></span> siteKey<span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">string</span></span> hostName<span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">string</span></span> language <span class="token operator">=</span> <span class="token string">&quot;en&quot;</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">string</span></span> tokenRecievedHtml <span class="token operator">=</span> <span class="token string">&quot;Token recieved: %token%&quot;</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">string</span></span> tokenRecievedHookedHtml <span class="token operator">=</span> <span class="token string">&quot;Token recieved and sent to application.&quot;</span><span class="token punctuation">,</span>
    <span class="token class-name">HttpServerConfig<span class="token punctuation">?</span></span> httpConfiguration <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><table><thead><tr><th>Parameter</th><th>Description</th></tr></thead><tbody><tr><td><code>this string</code> siteKey</td><td>The SiteKey for the Google reCAPTCHA service.</td></tr><tr><td><code>string</code> hostName</td><td>The name of the virtual host on which the reCAPTCHA is hosted. Should represent your application.</td></tr><tr><td><em><code>string</code> language</em></td><td>The language for the Google reCAPTCHA service.</td></tr><tr><td><em><code>string</code> tokenRecievedHtml</em></td><td>The HTML which gets displayed after the user verifed the reCAPTCHA. Use %token% to embed the token inside the message.</td></tr><tr><td><em><code>string</code> tokenRecievedHookedHtml</em></td><td>The HTML which gets displayed after the user verifed the reCAPTCHA and its hooked to the application. Use %token% to embed the token inside the message.</td></tr><tr><td><em><code>HttpServerConfig?</code> httpConfiguration</em></td><td>The configuration for the HttpServer.</td></tr></tbody></table><h3 id="aswindowconfig" tabindex="-1"><a class="header-anchor" href="#aswindowconfig" aria-hidden="true">#</a> AsWindowConfig</h3><p>Creates a new AsWindowConfig.</p><p><strong>Returns:</strong> A new AsWindowConfig.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">static</span> <span class="token return-type class-name">WindowConfig</span> <span class="token function">AsWindowConfig</span><span class="token punctuation">(</span>
    <span class="token keyword">this</span> <span class="token class-name"><span class="token keyword">string</span></span> title<span class="token punctuation">,</span>
    <span class="token class-name">ImageSource</span> icon <span class="token operator">=</span> <span class="token keyword">default</span><span class="token operator">!</span><span class="token punctuation">,</span>
    <span class="token class-name">Window<span class="token punctuation">?</span></span> owner <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">bool</span></span> showAsDialog <span class="token operator">=</span> <span class="token boolean">false</span><span class="token punctuation">,</span>
    <span class="token class-name">WindowStartupLocation</span> startupLocation <span class="token operator">=</span> WindowStartupLocation<span class="token punctuation">.</span>CenterScreen<span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">int</span></span> left <span class="token operator">=</span> <span class="token number">0</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">int</span></span> top <span class="token operator">=</span> <span class="token number">0</span><span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><table><thead><tr><th>Parameter</th><th>Description</th></tr></thead><tbody><tr><td><code>this string</code> title</td><td>The title of the window.</td></tr><tr><td><em><code>ImageSource</code> icon</em></td><td>The icon of the window.</td></tr><tr><td><em><code>Window?</code> owner</em></td><td>The owner of this window. (Only used for StartupLocation.CenterOwner).</td></tr><tr><td><em><code>bool</code> showAsDialog</em></td><td>Wether to block the UI thread when showing the window.</td></tr><tr><td><em><code>WindowStartupLocation?</code> startupLocation</em></td><td>The startup postion of the window.</td></tr><tr><td><em><code>int?</code> left</em></td><td>The left position of the window.</td></tr><tr><td><em><code>int?</code> top</em></td><td>The top position of the window.</td></tr></tbody></table>`,12);function f(b,C){const e=c("RouterLink");return i(),d("div",null,[l,u,n("p",null,[h,s(" Class "),k,m,s(),a(e,{to:"/reference/recaptcha.desktop.winui/configuration/"},{default:t(()=>[s("ReCaptcha.Desktop.WinUI.Configuration")]),_:1}),g,w,s(),a(e,{to:"/reference/recaptcha.desktop.winui/"},{default:t(()=>[s("ReCaptcha.Desktop.WinUI")]),_:1})]),v])}const _=o(r,[["render",f],["__file","extentions.html.vue"]]);export{_ as default};
