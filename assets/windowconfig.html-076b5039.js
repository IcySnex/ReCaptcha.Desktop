import{_ as s,M as r,p as d,q as i,R as e,t as n,N as t,V as a,a1 as c}from"./framework-c4f3d865.js";const p={},l=e("h1",{id:"windowconfig",tabindex:"-1"},[e("a",{class:"header-anchor",href:"#windowconfig","aria-hidden":"true"},"#"),n(" WindowConfig")],-1),h=e("p",null,"Configuration for a ReCaptcha window.",-1),u=e("strong",null,"Type:",-1),w=e("br",null,null,-1),g=e("strong",null,"Namespace:",-1),f=e("br",null,null,-1),k=e("strong",null,"Assembly:",-1),b=c(`<div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">class</span> <span class="token class-name">WindowConfig</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div></div></div><h2 id="constructors" tabindex="-1"><a class="header-anchor" href="#constructors" aria-hidden="true">#</a> Constructors</h2><p>Creates a new WindowConfig.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token function">WindowConfig</span><span class="token punctuation">(</span>
    <span class="token class-name"><span class="token keyword">string</span></span> title<span class="token punctuation">,</span>
    <span class="token class-name">ImageSource</span> icon <span class="token operator">=</span> <span class="token keyword">default</span><span class="token operator">!</span><span class="token punctuation">,</span>
    <span class="token class-name">Window<span class="token punctuation">?</span></span> owner <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">bool</span></span> showAsDialog <span class="token operator">=</span> <span class="token boolean">false</span><span class="token punctuation">,</span>
    <span class="token class-name">WindowStartupLocation</span> startupLocation <span class="token operator">=</span> WindowStartupLocation<span class="token punctuation">.</span>CenterScreen<span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">int</span></span> left <span class="token operator">=</span> <span class="token number">0</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">int</span></span> top <span class="token operator">=</span> <span class="token number">0</span><span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><table><thead><tr><th>Parameter</th><th>Description</th></tr></thead><tbody><tr><td><code>string</code> title</td><td>The title of the window.</td></tr><tr><td><em><code>ImageSource</code> icon</em></td><td>The icon of the window.</td></tr><tr><td><em><code>Window?</code> owner</em></td><td>The owner of this window. (Only used for StartupLocation.CenterOwner).</td></tr><tr><td><em><code>bool</code> showAsDialog</em></td><td>Wether to block the UI thread when showing the window.</td></tr><tr><td><em><code>WindowStartupLocation</code> startupLocation</em></td><td>The startup postion of the window.</td></tr><tr><td><em><code>int</code> left</em></td><td>The left position of the window.</td></tr><tr><td><em><code>int</code> top</em></td><td>The top position of the window.</td></tr></tbody></table><h2 id="properties" tabindex="-1"><a class="header-anchor" href="#properties" aria-hidden="true">#</a> Properties</h2><h3 id="title" tabindex="-1"><a class="header-anchor" href="#title" aria-hidden="true">#</a> Title</h3><p>The title of the window.</p><p><strong>Type</strong>: <code>string</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> none</p><h3 id="icon" tabindex="-1"><a class="header-anchor" href="#icon" aria-hidden="true">#</a> Icon</h3><p>The icon of the window.</p><p><strong>Type</strong>: <code>ImageSource</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>default!</code></p><h3 id="owner" tabindex="-1"><a class="header-anchor" href="#owner" aria-hidden="true">#</a> Owner</h3><p>The owner of this window. (Only used for StartupLocation.CenterOwner).</p><p><strong>Type</strong>: <code>Window?</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>null</code></p><h3 id="showasdialog" tabindex="-1"><a class="header-anchor" href="#showasdialog" aria-hidden="true">#</a> ShowAsDialog</h3><p>Wether to block the UI thread when showing the window.</p><p><strong>Type</strong>: <code>bool</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>false</code></p><h3 id="startuplocation" tabindex="-1"><a class="header-anchor" href="#startuplocation" aria-hidden="true">#</a> StartupLocation</h3><p>The startup postion of the window.</p><p><strong>Type</strong>: <code>WindowStartupLocation</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>WindowStartupLocation.CenterScreen</code></p><h3 id="left" tabindex="-1"><a class="header-anchor" href="#left" aria-hidden="true">#</a> Left</h3><p>The left position of the window.</p><p><strong>Type</strong>: <code>int</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>0</code></p><h3 id="top" tabindex="-1"><a class="header-anchor" href="#top" aria-hidden="true">#</a> Top</h3><p>The top position of the window.</p><p><strong>Type</strong>: <code>int</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>0</code></p>`,27);function m(_,v){const o=r("RouterLink");return d(),i("div",null,[l,h,e("p",null,[u,n(" Class "),w,g,n(),t(o,{to:"/reference/recaptcha.desktop.wpf/configuration/"},{default:a(()=>[n("ReCaptcha.Desktop.WPF.Configuration")]),_:1}),f,k,n(),t(o,{to:"/reference/recaptcha.desktop.wpf/"},{default:a(()=>[n("ReCaptcha.Desktop.WPF")]),_:1})]),b])}const y=s(p,[["render",m],["__file","windowconfig.html.vue"]]);export{y as default};
