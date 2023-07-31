import{_ as r,M as c,p as i,q as o,R as e,t as a,N as s,V as t,a1 as d}from"./framework-c4f3d865.js";const l={},p=e("h1",{id:"recaptchareciever",tabindex:"-1"},[e("a",{class:"header-anchor",href:"#recaptchareciever","aria-hidden":"true"},"#"),a(" ReCaptchaReciever")],-1),h=e("p",null,"Reciever to communicate with the HTTP server with extended resize functions.",-1),u=e("strong",null,"Type:",-1),v=e("br",null,null,-1),b=e("strong",null,"Namespace:",-1),g=e("br",null,null,-1),k=e("strong",null,"Assembly:",-1),f=d(`<div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">class</span> <span class="token class-name">ReCaptchaReciever</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div></div></div><h2 id="constructors" tabindex="-1"><a class="header-anchor" href="#constructors" aria-hidden="true">#</a> Constructors</h2><p>Creates a new ReCaptchaReciever.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token function">ReCaptchaReciever</span><span class="token punctuation">(</span><span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div></div></div><h2 id="properties" tabindex="-1"><a class="header-anchor" href="#properties" aria-hidden="true">#</a> Properties</h2><h3 id="verificationrecieved" tabindex="-1"><a class="header-anchor" href="#verificationrecieved" aria-hidden="true">#</a> VerificationRecieved</h3><p>Fires when verifcation was recieved from the HTTP server.</p><p><strong>Type</strong>: <code>EventHandler&lt;VerificationRecievedEventArgs&gt;?</code><br><strong>Modifier:</strong> <code>event</code></p><h3 id="verificationcancelled" tabindex="-1"><a class="header-anchor" href="#verificationcancelled" aria-hidden="true">#</a> VerificationCancelled</h3><p>Fires when verifcation was cancelled from the HTTP server.</p><p><strong>Type</strong>: <code>EventHandler&lt;VerificationCancelledEventArgs&gt;?</code><br><strong>Modifier:</strong> <code>event</code></p><h3 id="recaptcharesized" tabindex="-1"><a class="header-anchor" href="#recaptcharesized" aria-hidden="true">#</a> ReCaptchaResized</h3><p>Fires when Google reCAPTCHA widget gets resized.</p><p><strong>Type</strong>: <code>EventHandler&lt;ReCaptchaResizedEventArgs&gt;?</code><br><strong>Modifier:</strong> <code>event</code></p><h2 id="methods" tabindex="-1"><a class="header-anchor" href="#methods" aria-hidden="true">#</a> Methods</h2><h3 id="setwebview" tabindex="-1"><a class="header-anchor" href="#setwebview" aria-hidden="true">#</a> SetWebView</h3><p>Set the targeted CoreWebView for the ReCaptchaReciever.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token return-type class-name"><span class="token keyword">void</span></span> <span class="token function">SetWebView</span><span class="token punctuation">(</span>
    <span class="token class-name">CoreWebView2</span> coreWebView<span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div></div></div><table><thead><tr><th>Parameter</th><th>Description</th></tr></thead><tbody><tr><td><code>CoreWebView2</code> coreWebView</td><td>The WebView to hook the web message events.</td></tr></tbody></table><h3 id="waitasyc" tabindex="-1"><a class="header-anchor" href="#waitasyc" aria-hidden="true">#</a> WaitAsyc</h3><p>Asynchronously waits until a token was sent by the HTTP server.</p><p><strong>Returns:</strong> A Google reCAPTCHA token.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token return-type class-name">Task<span class="token punctuation">&lt;</span><span class="token keyword">string</span><span class="token punctuation">&gt;</span></span> <span class="token function">WaitAsyc</span><span class="token punctuation">(</span>
    <span class="token class-name">CancellationToken</span> cancellationToken<span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div></div></div><table><thead><tr><th>Parameter</th><th>Description</th></tr></thead><tbody><tr><td><code>CancellationToken</code> cancellationToken</td><td>The token to cancel this action.</td></tr></tbody></table>`,24);function m(w,_){const n=c("RouterLink");return i(),o("div",null,[p,h,e("p",null,[u,a(" Class "),v,b,a(),s(n,{to:"/reference/recaptcha.desktop.wpf/client/"},{default:t(()=>[a("ReCaptcha.Desktop.WPF.Client")]),_:1}),g,k,a(),s(n,{to:"/reference/recaptcha.desktop.wpf/"},{default:t(()=>[a("ReCaptcha.Desktop.WPF")]),_:1})]),f])}const y=r(l,[["render",m],["__file","recaptchareciever.html.vue"]]);export{y as default};