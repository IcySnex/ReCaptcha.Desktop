import{_ as o,M as c,p as i,q as r,R as e,t as n,N as t,V as s,a1 as d}from"./framework-c4f3d865.js";const p={},l=e("h1",{id:"recaptchaclient",tabindex:"-1"},[e("a",{class:"header-anchor",href:"#recaptchaclient","aria-hidden":"true"},"#"),n(" ReCaptchaClient")],-1),h=e("p",null,"Client which handles all ReCaptcha verifications.",-1),u=e("strong",null,"Type:",-1),g=e("br",null,null,-1),f=e("strong",null,"Namespace:",-1),C=e("br",null,null,-1),v=e("strong",null,"Assembly:",-1),b=e("br",null,null,-1),k=e("strong",null,"Inherits from:",-1),m=d(`<div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">class</span> <span class="token class-name">ReCaptchaBase</span> <span class="token punctuation">:</span> <span class="token type-list"><span class="token class-name">IReCaptchaBase</span></span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div></div></div><h2 id="constructors" tabindex="-1"><a class="header-anchor" href="#constructors" aria-hidden="true">#</a> Constructors</h2><p>Creates a new ReCaptchaClient.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token function">ReCaptchaClient</span><span class="token punctuation">(</span>
    <span class="token class-name">ReCaptchaConfig</span> configuration<span class="token punctuation">,</span>
    <span class="token class-name">PopupConfig</span> popupConfiguration<span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><table><thead><tr><th>Parameter</th><th>Description</th></tr></thead><tbody><tr><td><code>ReCaptchaConfig</code> configuration</td><td>The configuration the ReCaptchaClient should be created with.</td></tr><tr><td><code>PopupConfig</code> popupConfiguration</td><td>The configuration the reCAPTCHA popup will be created with.</td></tr></tbody></table><p>Creates a new ReCaptchaClient with extendended logging functions</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token function">ReCaptchaClient</span><span class="token punctuation">(</span>
    <span class="token class-name">ReCaptchaConfig</span> configuration<span class="token punctuation">,</span>
    <span class="token class-name">PopupConfig</span> popupConfiguration<span class="token punctuation">,</span>
    <span class="token class-name">ILogger<span class="token punctuation">&lt;</span>IReCaptchaClient<span class="token punctuation">&gt;</span></span> logger<span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><table><thead><tr><th>Parameter</th><th>Description</th></tr></thead><tbody><tr><td><code>ReCaptchaConfig</code> configuration</td><td>The configuration the ReCaptchaClient should be created with.</td></tr><tr><td><code>PopupConfig</code> popupConfiguration</td><td>The configuration the reCAPTCHA popup will be created with.</td></tr><tr><td><code>ILogger&lt;IReCaptchaClient&gt;</code> logger</td><td>A logger from Dependency Injection with MVVM.</td></tr></tbody></table><h2 id="properties" tabindex="-1"><a class="header-anchor" href="#properties" aria-hidden="true">#</a> Properties</h2><h3 id="configuration" tabindex="-1"><a class="header-anchor" href="#configuration" aria-hidden="true">#</a> Configuration</h3><p>The configuration used for this client.</p><p><strong>Type</strong>: <code>ReCaptchaConfig</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> none</p><h3 id="popupconfiguration" tabindex="-1"><a class="header-anchor" href="#popupconfiguration" aria-hidden="true">#</a> PopupConfiguration</h3><p>The popup configuration used for this client.</p><p><strong>Type</strong>: <code>PopupConfig</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> none</p><h3 id="verificationrecieved" tabindex="-1"><a class="header-anchor" href="#verificationrecieved" aria-hidden="true">#</a> VerificationRecieved</h3><p>Fires when verifcation was recieved.</p><p><strong>Type</strong>: <code>EventHandler&lt;VerificationRecievedEventArgs&gt;?</code><br><strong>Modifier:</strong> <code>event</code></p><h3 id="verificationcancelled" tabindex="-1"><a class="header-anchor" href="#verificationcancelled" aria-hidden="true">#</a> VerificationCancelled</h3><p>Fires when verifcation was cancelled.</p><p><strong>Type</strong>: <code>EventHandler&lt;VerificationCancelledEventArgs&gt;?</code><br><strong>Modifier:</strong> <code>event</code></p><h3 id="recaptcharesized" tabindex="-1"><a class="header-anchor" href="#recaptcharesized" aria-hidden="true">#</a> ReCaptchaResized</h3><p>Fires when verifcation was cancelled.</p><p><strong>Type</strong>: <code>EventHandler&lt;ReCaptchaResizedEventArgs&gt;?</code><br><strong>Modifier:</strong> <code>event</code></p><h2 id="methods" tabindex="-1"><a class="header-anchor" href="#methods" aria-hidden="true">#</a> Methods</h2><h3 id="verifyasync" tabindex="-1"><a class="header-anchor" href="#verifyasync" aria-hidden="true">#</a> VerifyAsync</h3><p>Sets up the reCAPTCHA site and opens a new window for the user to verify.</p><p><strong>Returns:</strong> A Google reCAPTCHA token.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token return-type class-name">Task<span class="token punctuation">&lt;</span><span class="token keyword">string</span><span class="token punctuation">&gt;</span></span> <span class="token function">VerifyAsync</span><span class="token punctuation">(</span>
    <span class="token class-name">CancellationToken</span> cancellationToken <span class="token operator">=</span> <span class="token keyword">default</span><span class="token operator">!</span><span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div></div></div><table><thead><tr><th>Parameter</th><th>Description</th></tr></thead><tbody><tr><td><em><code>CancellationToken</code> cancellationToken</em></td><td>The token to cancel this action.</td></tr></tbody></table>`,30);function _(y,w){const a=c("RouterLink");return i(),r("div",null,[l,h,e("p",null,[u,n(" Class "),g,f,n(),t(a,{to:"/reference/recaptcha.desktop.uwp/client/"},{default:s(()=>[n("ReCaptcha.Desktop.UWP.Client")]),_:1}),C,v,n(),t(a,{to:"/reference/recaptcha.desktop.uwp/"},{default:s(()=>[n("ReCaptcha.Desktop.UWP")]),_:1}),b,k,n(),t(a,{to:"/reference/recaptcha.desktop.uwp/client/interfaces/irecaptchaclient.html"},{default:s(()=>[n("IReCaptchaClient")]),_:1})]),m])}const T=o(p,[["render",_],["__file","recaptchaclient.html.vue"]]);export{T as default};
