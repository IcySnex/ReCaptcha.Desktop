import{_ as t,M as r,p as d,q as i,R as e,t as n,N as s,V as o,a1 as p}from"./framework-c4f3d865.js";const c={},l=e("h1",{id:"popupconfig",tabindex:"-1"},[e("a",{class:"header-anchor",href:"#popupconfig","aria-hidden":"true"},"#"),n(" PopupConfig")],-1),u=e("p",null,"Configuration for a ReCaptcha popup.",-1),h=e("strong",null,"Type:",-1),g=e("br",null,null,-1),b=e("strong",null,"Namespace:",-1),m=e("br",null,null,-1),f=e("strong",null,"Assembly:",-1),k=p(`<div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">class</span> <span class="token class-name">PopupConfig</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div></div></div><h2 id="constructors" tabindex="-1"><a class="header-anchor" href="#constructors" aria-hidden="true">#</a> Constructors</h2><p>Creates a new PopupConfig.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token function">PopupConfig</span><span class="token punctuation">(</span>
    <span class="token class-name"><span class="token keyword">string</span><span class="token punctuation">?</span></span> title <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">,</span>
    <span class="token class-name">ImageSource<span class="token punctuation">?</span></span> icon <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">bool</span></span> hasTitlebar <span class="token operator">=</span> <span class="token boolean">true</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">bool</span></span> isDraggable <span class="token operator">=</span> <span class="token boolean">false</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">bool</span></span> isDimmed <span class="token operator">=</span> <span class="token boolean">true</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">bool</span><span class="token punctuation">?</span></span> hasRoundedCorners <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">,</span>
    <span class="token class-name">PopupStartupLocation</span> startupLocation <span class="token operator">=</span> PopupStartupLocation<span class="token punctuation">.</span>CenterPrimary<span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">int</span></span> left <span class="token operator">=</span> <span class="token number">0</span><span class="token punctuation">,</span>
    <span class="token class-name"><span class="token keyword">int</span></span> top <span class="token operator">=</span> <span class="token number">0</span><span class="token punctuation">)</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><table><thead><tr><th>Parameter</th><th>Description</th></tr></thead><tbody><tr><td><em><code>string?</code> title</em></td><td>The title of the dialog (Only used when HasTitleBar is true).</td></tr><tr><td><em><code>ImageSource?</code> icon</em></td><td>The icon of the dialog (Only used when HasTitleBar is true).</td></tr><tr><td><em><code>bool</code> hasTitlebar</em></td><td>Wether the dialog has a TitleBar.</td></tr><tr><td><em><code>bool</code> isDraggable</em></td><td>Wether the dialog is draggable within the main window (Only used when HasTitleBar is true).</td></tr><tr><td><em><code>bool</code> isDimmed</em></td><td>Wether the dialog dims the main windows background.</td></tr><tr><td><em><code>bool?</code> hasRoundedCorners</em></td><td>Wether the window has rounded corners (If null the value is true on Windows 11 and false on Windows 10).</td></tr><tr><td><em><code>PopupStartupLocation</code> startupLocation</em></td><td>The startup location of the popup.</td></tr><tr><td><em><code>int</code> left</em></td><td>The left position of the window.</td></tr><tr><td><em><code>int</code> top</em></td><td>The top position of the window.</td></tr></tbody></table><h2 id="properties" tabindex="-1"><a class="header-anchor" href="#properties" aria-hidden="true">#</a> Properties</h2><h3 id="title" tabindex="-1"><a class="header-anchor" href="#title" aria-hidden="true">#</a> Title</h3><p>The title of the dialog (Only used when HasTitleBar is true).</p><p><strong>Type</strong>: <code>string?</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>null</code></p><h3 id="icon" tabindex="-1"><a class="header-anchor" href="#icon" aria-hidden="true">#</a> Icon</h3><p>The icon of the dialog (Only used when HasTitleBar is true).</p><p><strong>Type</strong>: <code>ImageSource?</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>null</code></p><h3 id="hastitlebar" tabindex="-1"><a class="header-anchor" href="#hastitlebar" aria-hidden="true">#</a> HasTitleBar</h3><p>Wether the dialog has a TitleBar.</p><p><strong>Type</strong>: <code>bool</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>true</code></p><h3 id="isdragable" tabindex="-1"><a class="header-anchor" href="#isdragable" aria-hidden="true">#</a> IsDragable</h3><p>Wether the dialog is draggable within the main window (Only used when HasTitleBar is true).</p><p><strong>Type</strong>: <code>bool</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>false</code></p><h3 id="isdimmed" tabindex="-1"><a class="header-anchor" href="#isdimmed" aria-hidden="true">#</a> IsDimmed</h3><p>Wether the dialog dims the main windows background.</p><p><strong>Type</strong>: <code>bool</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>true</code></p><h3 id="hasroundedcorners" tabindex="-1"><a class="header-anchor" href="#hasroundedcorners" aria-hidden="true">#</a> HasRoundedCorners</h3><p>Wether the window has rounded corners (If null the value is true on Windows 11 and false on Windows 10).</p><p><strong>Type</strong>: <code>bool?</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>null</code></p><h3 id="startuplocation" tabindex="-1"><a class="header-anchor" href="#startuplocation" aria-hidden="true">#</a> StartupLocation</h3><p>The startup location of the popup.</p><p><strong>Type</strong>: <code>PopupStartupLocation</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>PopupStartupLocation.CenterPrimary</code></p><h3 id="left" tabindex="-1"><a class="header-anchor" href="#left" aria-hidden="true">#</a> Left</h3><p>The left position of the popup.</p><p><strong>Type</strong>: <code>int</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>0</code></p><h3 id="top" tabindex="-1"><a class="header-anchor" href="#top" aria-hidden="true">#</a> Top</h3><p>The top position of the popup.</p><p><strong>Type</strong>: <code>int</code><br><strong>Modifier:</strong> none <br><strong>Default Value:</strong> <code>0</code></p>`,33);function w(v,y){const a=r("RouterLink");return d(),i("div",null,[l,u,e("p",null,[h,n(" Class "),g,b,n(),s(a,{to:"/reference/recaptcha.desktop.uwp/configuration/"},{default:o(()=>[n("ReCaptcha.Desktop.UWP.Configuration")]),_:1}),m,f,n(),s(a,{to:"/reference/recaptcha.desktop.uwp/"},{default:o(()=>[n("ReCaptcha.Desktop.UWP")]),_:1})]),k])}const _=t(c,[["render",w],["__file","popupconfig.html.vue"]]);export{_ as default};