import{_ as c,M as a,p as d,q as i,R as e,t,N as s,V as r,a1 as p}from"./framework-c4f3d865.js";const l={},h=e("h1",{id:"recaptcharesizedeventargs",tabindex:"-1"},[e("a",{class:"header-anchor",href:"#recaptcharesizedeventargs","aria-hidden":"true"},"#"),t(" ReCaptchaResizedEventArgs")],-1),u=e("p",null,"Event arguments for when a reCAPTCHA widget was resized.",-1),g=e("strong",null,"Type:",-1),_=e("br",null,null,-1),m=e("strong",null,"Namespace:",-1),k=e("br",null,null,-1),v=e("strong",null,"Assembly:",-1),b=e("br",null,null,-1),f=e("strong",null,"Inherits from:",-1),w={href:"https://learn.microsoft.com/dotnet/api/system.eventargs",target:"_blank",rel:"noopener noreferrer"},C=p(`<div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">class</span> <span class="token class-name">ReCaptchaResizedEventArgs</span> <span class="token punctuation">:</span> <span class="token type-list"><span class="token class-name">System<span class="token punctuation">.</span>EventArgs</span></span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div></div></div><h2 id="constructors" tabindex="-1"><a class="header-anchor" href="#constructors" aria-hidden="true">#</a> Constructors</h2><p>Creates new ReCaptchaResizedEventArgs.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token punctuation">[</span><span class="token attribute"><span class="token class-name">JsonConstructor</span></span><span class="token punctuation">]</span>
<span class="token keyword">public</span> <span class="token function">ReCaptchaResizedEventArgs</span><span class="token punctuation">(</span>
    <span class="token class-name"><span class="token keyword">int</span></span> width<span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">int</span></span> height<span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><table><thead><tr><th>Parameter</th><th>Description</th></tr></thead><tbody><tr><td><code>int</code> width</td><td>The new width of the reCAPTCHA widget.</td></tr><tr><td><code>int</code> height</td><td>The new height of the reCAPTCHA widget.</td></tr></tbody></table><h2 id="properties" tabindex="-1"><a class="header-anchor" href="#properties" aria-hidden="true">#</a> Properties</h2><h3 id="width" tabindex="-1"><a class="header-anchor" href="#width" aria-hidden="true">#</a> Width</h3><p>The new width of the reCAPTCHA widget.</p><p><strong>Type</strong>: <code>int</code><br><strong>Modifier:</strong> <code>readonly</code>, <code>[JsonPropertyName(&quot;width&quot;)]</code><br><strong>Default Value:</strong> none</p><h3 id="height" tabindex="-1"><a class="header-anchor" href="#height" aria-hidden="true">#</a> Height</h3><p>The new height of the reCAPTCHA widget.</p><p><strong>Type</strong>: <code>int</code><br><strong>Modifier:</strong> <code>readonly</code>, <code>[JsonPropertyName(&quot;width&quot;)]</code><br><strong>Default Value:</strong> none</p><h3 id="occurredat" tabindex="-1"><a class="header-anchor" href="#occurredat" aria-hidden="true">#</a> OccurredAt</h3><p>The date and time when it got resized.</p><p><strong>Type</strong>: <code>DateTime</code><br><strong>Modifier:</strong> <code>readonly</code><br><strong>Default Value:</strong> <code>DateTime.Now</code></p>`,15);function y(A,T){const n=a("RouterLink"),o=a("ExternalLinkIcon");return d(),i("div",null,[h,u,e("p",null,[g,t(" Class "),_,m,t(),s(n,{to:"/reference/recaptcha.desktop.uwp/eventargs/"},{default:r(()=>[t("ReCaptcha.Desktop.UWP.EventArgs")]),_:1}),k,v,t(),s(n,{to:"/reference/recaptcha.desktop.uwp/"},{default:r(()=>[t("ReCaptcha.Desktop.UWP")]),_:1}),b,f,t(),e("a",w,[t("EventArgs"),s(o)])]),C])}const R=c(l,[["render",y],["__file","recaptcharesizedeventargs.html.vue"]]);export{R as default};