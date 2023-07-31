import{_ as r,M as i,p as o,q as c,R as e,t as n,N as t,V as s,a1 as d}from"./framework-c4f3d865.js";const l={},p=e("h1",{id:"irecaptchaclient",tabindex:"-1"},[e("a",{class:"header-anchor",href:"#irecaptchaclient","aria-hidden":"true"},"#"),n(" IReCaptchaClient")],-1),h=e("p",null,"Client which handles all ReCaptcha verifications.",-1),u=e("strong",null,"Type:",-1),f=e("br",null,null,-1),g=e("strong",null,"Namespace:",-1),v=e("br",null,null,-1),k=e("strong",null,"Assembly:",-1),_=d(`<div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">interface</span> <span class="token class-name">IReCaptchaClient</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div></div></div><h2 id="properties" tabindex="-1"><a class="header-anchor" href="#properties" aria-hidden="true">#</a> Properties</h2><h3 id="configuration" tabindex="-1"><a class="header-anchor" href="#configuration" aria-hidden="true">#</a> Configuration</h3><p>The configuration used for this client.</p><p><strong>Type</strong>: <code>ReCaptchaConfig</code><br><strong>Modifier:</strong> none</p><h3 id="windowconfiguration" tabindex="-1"><a class="header-anchor" href="#windowconfiguration" aria-hidden="true">#</a> WindowConfiguration</h3><p>The window configuration used for this client.</p><p><strong>Type</strong>: <code>WindowConfig</code><br><strong>Modifier:</strong> none</p><h3 id="verificationrecieved" tabindex="-1"><a class="header-anchor" href="#verificationrecieved" aria-hidden="true">#</a> VerificationRecieved</h3><p>Fires when verifcation was recieved.</p><p><strong>Type</strong>: <code>EventHandler&lt;VerificationRecievedEventArgs&gt;?</code><br><strong>Modifier:</strong> <code>event</code></p><h3 id="verificationcancelled" tabindex="-1"><a class="header-anchor" href="#verificationcancelled" aria-hidden="true">#</a> VerificationCancelled</h3><p>Fires when verifcation was cancelled.</p><p><strong>Type</strong>: <code>EventHandler&lt;VerificationCancelledEventArgs&gt;?</code><br><strong>Modifier:</strong> <code>event</code></p><h3 id="recaptcharesized" tabindex="-1"><a class="header-anchor" href="#recaptcharesized" aria-hidden="true">#</a> ReCaptchaResized</h3><p>Fires when Google reCAPTCHA widget gets resized.</p><p><strong>Type</strong>: <code>EventHandler&lt;ReCaptchaResizedEventArgs&gt;?</code><br><strong>Modifier:</strong> <code>event</code></p><h2 id="methods" tabindex="-1"><a class="header-anchor" href="#methods" aria-hidden="true">#</a> Methods</h2><h3 id="verifyasync" tabindex="-1"><a class="header-anchor" href="#verifyasync" aria-hidden="true">#</a> VerifyAsync</h3><p>Sets up the reCAPTCHA site and opens a new window for the user to verify.</p><p><strong>Returns:</strong> A Google reCAPTCHA token.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token return-type class-name">Task<span class="token punctuation">&lt;</span><span class="token keyword">string</span><span class="token punctuation">&gt;</span></span> <span class="token function">VerifyAsync</span><span class="token punctuation">(</span>
    <span class="token class-name">CancellationToken</span> cancellationToken <span class="token operator">=</span> <span class="token keyword">default</span><span class="token operator">!</span><span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div></div></div><table><thead><tr><th>Parameter</th><th>Description</th></tr></thead><tbody><tr><td><em><code>CancellationToken</code> cancellationToken</em></td><td>The token to cancel this action.</td></tr></tbody></table>`,23);function b(C,m){const a=i("RouterLink");return o(),c("div",null,[p,h,e("p",null,[u,n(" Interface "),f,g,n(),t(a,{to:"/reference/recaptcha.desktop.wpf/client/interfaces/"},{default:s(()=>[n("ReCaptcha.Desktop.WPF.Client.Interfaces")]),_:1}),v,k,n(),t(a,{to:"/reference/recaptcha.desktop.wpf/"},{default:s(()=>[n("ReCaptcha.Desktop.WPF")]),_:1})]),_])}const y=r(l,[["render",b],["__file","irecaptchaclient.html.vue"]]);export{y as default};