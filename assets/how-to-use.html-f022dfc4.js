import{_ as c,M as o,p as i,q as l,R as s,t as n,N as a,V as u,a1 as t}from"./framework-c4f3d865.js";const r="/ReCaptcha.Desktop/guide/how-to-use/userinterface.gif",d="/ReCaptcha.Desktop/guide/how-to-use/finished.gif",k="/ReCaptcha.Desktop/guide/how-to-use/finished-user.gif",v={},m=s("h1",{id:"how-to-use-mvvm",tabindex:"-1"},[s("a",{class:"header-anchor",href:"#how-to-use-mvvm","aria-hidden":"true"},"#"),n(" How to use (MVVM)")],-1),h={href:"https://learn.microsoft.com/en-us/dotnet/desktop/wpf",target:"_blank",rel:"noopener noreferrer"},g={href:"https://learn.microsoft.com/en-us/windows/apps/winui/winui3/",target:"_blank",rel:"noopener noreferrer"},b={href:"https://learn.microsoft.com/windows/uwp/",target:"_blank",rel:"noopener noreferrer"},f={href:"https://learn.microsoft.com/dotnet/core/extensions/dependency-injection",target:"_blank",rel:"noopener noreferrer"},w={href:"https://learn.microsoft.com/dotnet/communitytoolkit/mvvm/",target:"_blank",rel:"noopener noreferrer"},y=t(`<h3 id="step-1-install-recaptcha-desktop-package" tabindex="-1"><a class="header-anchor" href="#step-1-install-recaptcha-desktop-package" aria-hidden="true">#</a> Step 1: Install ReCaptcha.Desktop package</h3><div class="language-powershell line-numbers-mode" data-ext="powershell"><pre class="language-powershell"><code>dotnet add &lt;PROJECT&gt; package ReCaptcha<span class="token punctuation">.</span>Desktop<span class="token punctuation">.</span>WPF <span class="token comment"># WPF</span>
dotnet add &lt;PROJECT&gt; package ReCaptcha<span class="token punctuation">.</span>Desktop<span class="token punctuation">.</span>WinUI <span class="token comment"># WinUI3</span>
dotnet add &lt;PROJECT&gt; package ReCaptcha<span class="token punctuation">.</span>Desktop<span class="token punctuation">.</span>UWP <span class="token comment"># UWP</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div>`,2),C={id:"step-2-add-recaptcha-service-to-your-app-serviceprovider",tabindex:"-1"},_=s("a",{class:"header-anchor",href:"#step-2-add-recaptcha-service-to-your-app-serviceprovider","aria-hidden":"true"},"#",-1),x={href:"https://learn.microsoft.com/dotnet/api/microsoft.extensions.dependencyinjection.serviceprovider",target:"_blank",rel:"noopener noreferrer"},T={href:"https://learn.microsoft.com/en-us/dotnet/core/extensions/logging",target:"_blank",rel:"noopener noreferrer"},V={href:"https://serilog.net/",target:"_blank",rel:"noopener noreferrer"},M=s("code",null,"ILogger<IReCaptchaClient>",-1),R=t(`<p>This is what a simple example App.cs class could look like:</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">readonly</span> <span class="token class-name">IHost</span> host<span class="token punctuation">;</span>
<span class="token keyword">public</span> <span class="token keyword">static</span> <span class="token return-type class-name">IServiceProvider</span> Provider <span class="token punctuation">{</span> <span class="token keyword">get</span><span class="token punctuation">;</span> <span class="token keyword">private</span> <span class="token keyword">set</span><span class="token punctuation">;</span> <span class="token punctuation">}</span> <span class="token operator">=</span> <span class="token keyword">default</span><span class="token operator">!</span><span class="token punctuation">;</span>

<span class="token keyword">public</span> <span class="token function">App</span><span class="token punctuation">(</span><span class="token punctuation">)</span>
<span class="token punctuation">{</span>
    host <span class="token operator">=</span> Host<span class="token punctuation">.</span><span class="token function">CreateDefaultBuilder</span><span class="token punctuation">(</span><span class="token punctuation">)</span>
        <span class="token punctuation">.</span><span class="token function">ConfigureLogging</span><span class="token punctuation">(</span>logging <span class="token operator">=&gt;</span>
        <span class="token punctuation">{</span>
            logging<span class="token punctuation">.</span><span class="token function">ClearProviders</span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">;</span>
            logging<span class="token punctuation">.</span><span class="token function">AddDebug</span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">;</span>
        <span class="token punctuation">}</span><span class="token punctuation">)</span>
        <span class="token punctuation">.</span><span class="token function">ConfigureServices</span><span class="token punctuation">(</span><span class="token punctuation">(</span>context<span class="token punctuation">,</span> services<span class="token punctuation">)</span> <span class="token operator">=&gt;</span>
        <span class="token punctuation">{</span>
            <span class="token comment">// Add Services</span>
            services<span class="token punctuation">.</span><span class="token generic-method"><span class="token function">AddSingleton</span><span class="token generic class-name"><span class="token punctuation">&lt;</span>IReCaptchaClient<span class="token punctuation">&gt;</span></span></span><span class="token punctuation">(</span>provider <span class="token operator">=&gt;</span> <span class="token keyword">new</span> <span class="token constructor-invocation class-name">ReCaptchaClient</span><span class="token punctuation">(</span>
                <span class="token string">&quot;GOOGLE_SITE_KEY&quot;</span><span class="token punctuation">.</span><span class="token function">AsReCaptchaConfig</span><span class="token punctuation">(</span><span class="token string">&quot;HOST_NAME&quot;</span><span class="token punctuation">)</span><span class="token punctuation">,</span>
                <span class="token string">&quot;WINDOW_TITLE&quot;</span><span class="token punctuation">.</span><span class="token function">AsWindowConfig</span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">,</span>
                provider<span class="token punctuation">.</span><span class="token generic-method"><span class="token function">GetRequiredService</span><span class="token generic class-name"><span class="token punctuation">&lt;</span>ILogger<span class="token punctuation">&lt;</span>IReCaptchaClient<span class="token punctuation">&gt;</span><span class="token punctuation">&gt;</span></span></span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">)</span><span class="token punctuation">)</span><span class="token punctuation">;</span>

            <span class="token comment">// Add ViewModels</span>

        <span class="token punctuation">}</span><span class="token punctuation">)</span>
        <span class="token punctuation">.</span><span class="token function">Build</span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">;</span>
    Provider <span class="token operator">=</span> host<span class="token punctuation">.</span>Services<span class="token punctuation">;</span>
<span class="token punctuation">}</span>
</code></pre><div class="highlight-lines"><br><br><br><br><br><br><br><br><br><br><br><br><br><br><div class="highlight-line"> </div><div class="highlight-line"> </div><div class="highlight-line"> </div><div class="highlight-line"> </div><br><br><br><br><br><br><br></div><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><h3 id="step-3-create-a-new-view-and-viewmodel" tabindex="-1"><a class="header-anchor" href="#step-3-create-a-new-view-and-viewmodel" aria-hidden="true">#</a> Step 3: Create a new View and ViewModel</h3><p>The View is called <code>CaptchaView</code>. In a real world application you probably have a ViewModelLocator or something like that but for now we will just set the <code>DataContext</code> of the view in the constrcutor:</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token function">CaptchaView</span><span class="token punctuation">(</span><span class="token punctuation">)</span>
<span class="token punctuation">{</span>
    <span class="token function">InitializeComponent</span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">;</span>
    DataContext <span class="token operator">=</span> App<span class="token punctuation">.</span>Provider<span class="token punctuation">.</span><span class="token generic-method"><span class="token function">GetRequiredService</span><span class="token generic class-name"><span class="token punctuation">&lt;</span>CaptchaViewModel<span class="token punctuation">&gt;</span></span></span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">;</span>
<span class="token punctuation">}</span>
</code></pre><div class="highlight-lines"><br><br><br><div class="highlight-line"> </div><br></div><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><p>The ViewModel is called <code>CaptchaViewModel</code>. We will get a <code>ILogger&lt;T&gt;</code> and the <code>ReCaptchaClient</code> through the constructor sicne we are using Dependency Injection:</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token keyword">public</span> <span class="token keyword">class</span> <span class="token class-name">CaptchaViewModel</span> <span class="token punctuation">:</span> <span class="token type-list"><span class="token class-name">ObservableObject</span></span>
<span class="token punctuation">{</span>
    <span class="token keyword">readonly</span> <span class="token class-name">ILogger<span class="token punctuation">&lt;</span>CaptchaViewModel<span class="token punctuation">&gt;</span></span> logger<span class="token punctuation">;</span>
    <span class="token keyword">readonly</span> <span class="token class-name">IReCaptchaClient</span> reCaptcha<span class="token punctuation">;</span>

    <span class="token keyword">public</span> <span class="token function">CaptchaViewModel</span><span class="token punctuation">(</span>
        <span class="token class-name">ILogger<span class="token punctuation">&lt;</span>CaptchaViewModel<span class="token punctuation">&gt;</span></span> logger<span class="token punctuation">,</span>
        <span class="token class-name">IReCaptchaClient</span> reCaptcha<span class="token punctuation">)</span>
    <span class="token punctuation">{</span>
        <span class="token keyword">this</span><span class="token punctuation">.</span>logger <span class="token operator">=</span> logger<span class="token punctuation">;</span>
        <span class="token keyword">this</span><span class="token punctuation">.</span>reCaptcha <span class="token operator">=</span> reCaptcha<span class="token punctuation">;</span>
    <span class="token punctuation">}</span>
<span class="token punctuation">}</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><p>Make sure to add the ViewModel to your App ServiceProvider:</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token range operator">..</span><span class="token punctuation">.</span>
<span class="token comment">// Add ViewModels</span>
services<span class="token punctuation">.</span><span class="token generic-method"><span class="token function">AddSingleton</span><span class="token generic class-name"><span class="token punctuation">&lt;</span>CaptchaViewModel<span class="token punctuation">&gt;</span></span></span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">;</span>
<span class="token range operator">..</span><span class="token punctuation">.</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><h3 id="step-4-add-an-user-interface" tabindex="-1"><a class="header-anchor" href="#step-4-add-an-user-interface" aria-hidden="true">#</a> Step 4: Add an User Interface</h3>`,10),I={href:"https://github.com/IcySnex/ReCaptcha.Desktop/blob/main/Samples/SimpleExampleMVVM/Views/CaptchaView.xaml",target:"_blank",rel:"noopener noreferrer"},A=s("img",{src:r,alt:""},null,-1),q=t(`<h3 id="step-5-add-logic-to-your-viewmodel" tabindex="-1"><a class="header-anchor" href="#step-5-add-logic-to-your-viewmodel" aria-hidden="true">#</a> Step 5: Add logic to your ViewModel</h3><p>The ReCaptcha.Desktop widget supports both MVVM and non-MVVM applications so you can also use <code>EventHandlers</code> instead of <code>Commands</code> and edit the control properties without <code>Bindings</code>.</p><div class="language-csharp line-numbers-mode" data-ext="cs"><pre class="language-csharp"><code><span class="token comment">// The verification will return an official Google reCAPTCHA token which could be used to verify other Google services</span>
<span class="token punctuation">[</span>ObservableProperty<span class="token punctuation">]</span>
<span class="token class-name"><span class="token keyword">string</span><span class="token punctuation">?</span></span> token <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">;</span>

<span class="token comment">// This property enables/disables the checked state on the reCAPTCHA widget</span>
<span class="token punctuation">[</span>ObservableProperty<span class="token punctuation">]</span>
<span class="token class-name"><span class="token keyword">bool</span></span> isChecked <span class="token operator">=</span> <span class="token boolean">false</span><span class="token punctuation">;</span>

<span class="token comment">// This property enables/Disables the loading indicator on the reCAPTCHA widget</span>
<span class="token punctuation">[</span>ObservableProperty<span class="token punctuation">]</span>
<span class="token class-name"><span class="token keyword">bool</span></span> isLoading <span class="token operator">=</span> <span class="token boolean">false</span><span class="token punctuation">;</span>

<span class="token comment">// This property allows you to show an error message on the reCAPTCHA widget. null if no error</span>
<span class="token punctuation">[</span>ObservableProperty<span class="token punctuation">]</span>
<span class="token class-name"><span class="token keyword">string</span><span class="token punctuation">?</span></span> errorMessage <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">;</span>


<span class="token class-name">CancellationTokenSource<span class="token punctuation">?</span></span> cancellationTokenSource <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">;</span>

<span class="token comment">// This method will request a new verification</span>
<span class="token punctuation">[</span>RelayCommand<span class="token punctuation">]</span>
<span class="token keyword">async</span> <span class="token return-type class-name">Task</span> <span class="token function">VerifyAsync</span><span class="token punctuation">(</span><span class="token punctuation">)</span>
<span class="token punctuation">{</span>
    <span class="token comment">// Remove any error message if existing and indicate loading</span>
    ErrorMessage <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">;</span>
    IsLoading <span class="token operator">=</span> <span class="token boolean">true</span><span class="token punctuation">;</span>

    <span class="token keyword">try</span> <span class="token comment">// Start verification</span>
    <span class="token punctuation">{</span>
        <span class="token comment">// Create a new cancellation source with a timeout of one minute</span>
        cancellationTokenSource <span class="token operator">=</span> <span class="token keyword">new</span><span class="token punctuation">(</span>TimeSpan<span class="token punctuation">.</span><span class="token function">FromMinutes</span><span class="token punctuation">(</span><span class="token number">1</span><span class="token punctuation">)</span><span class="token punctuation">)</span><span class="token punctuation">;</span>
        Token <span class="token operator">=</span> <span class="token keyword">await</span> reCaptcha<span class="token punctuation">.</span><span class="token function">VerifyAsync</span><span class="token punctuation">(</span>cancellationTokenSource<span class="token punctuation">.</span>Token<span class="token punctuation">)</span><span class="token punctuation">;</span>
    <span class="token punctuation">}</span>
    <span class="token keyword">catch</span> <span class="token punctuation">(</span><span class="token class-name">TaskCanceledException</span><span class="token punctuation">)</span> <span class="token comment">// The Verification was cancelled by the user or it timed out</span>
    <span class="token punctuation">{</span>
        <span class="token comment">// Reset token and uncheck</span>
        Token <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">;</span>
        IsChecked <span class="token operator">=</span> <span class="token boolean">false</span><span class="token punctuation">;</span>
    <span class="token punctuation">}</span>
    <span class="token keyword">catch</span> <span class="token punctuation">(</span><span class="token class-name">Exception</span> ex<span class="token punctuation">)</span> <span class="token comment">// Unexpected error was thrown</span>
    <span class="token punctuation">{</span>
        <span class="token comment">// Reset token, Set error message and uncheck</span>
        Token <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">;</span>
        IsChecked <span class="token operator">=</span> <span class="token boolean">false</span><span class="token punctuation">;</span>
        ErrorMessage <span class="token operator">=</span> ex<span class="token punctuation">.</span>Message<span class="token punctuation">;</span>
    <span class="token punctuation">}</span>
    <span class="token keyword">finally</span>
    <span class="token punctuation">{</span>
        <span class="token comment">// Disable loading and reset cancellation source</span>
        IsLoading <span class="token operator">=</span> <span class="token boolean">false</span><span class="token punctuation">;</span>
        cancellationTokenSource <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">;</span>
    <span class="token punctuation">}</span>
<span class="token punctuation">}</span>

<span class="token comment">// This method will remove the verification or cancel it if currently verificating</span>
<span class="token punctuation">[</span>RelayCommand<span class="token punctuation">]</span>
<span class="token return-type class-name"><span class="token keyword">void</span></span> <span class="token function">RemoveVerification</span><span class="token punctuation">(</span><span class="token punctuation">)</span>
<span class="token punctuation">{</span>
    <span class="token comment">// Reset token and cancel verification if not already reset</span>
    Token <span class="token operator">=</span> <span class="token keyword">null</span><span class="token punctuation">;</span>
    cancellationTokenSource<span class="token punctuation">?.</span><span class="token function">Cancel</span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">;</span>
<span class="token punctuation">}</span>


<span class="token comment">// Send a new registration or whatever</span>
<span class="token punctuation">[</span>RelayCommand<span class="token punctuation">]</span>
<span class="token return-type class-name"><span class="token keyword">void</span></span> <span class="token function">SendRegistration</span><span class="token punctuation">(</span><span class="token punctuation">)</span>
<span class="token punctuation">{</span>
    <span class="token keyword">if</span> <span class="token punctuation">(</span>Token <span class="token keyword">is</span> <span class="token keyword">null</span><span class="token punctuation">)</span>
    <span class="token punctuation">{</span>
        MessageBox<span class="token punctuation">.</span><span class="token function">Show</span><span class="token punctuation">(</span><span class="token string">&quot;Please confirm that you are not a robot!&quot;</span><span class="token punctuation">,</span> <span class="token string">&quot;Verification failed!&quot;</span><span class="token punctuation">,</span> MessageBoxButton<span class="token punctuation">.</span>OK<span class="token punctuation">,</span> MessageBoxImage<span class="token punctuation">.</span>Error<span class="token punctuation">)</span><span class="token punctuation">;</span>
        <span class="token keyword">return</span><span class="token punctuation">;</span>
    <span class="token punctuation">}</span>

    <span class="token comment">// Verification was successful. Here could be a call to another API which requires an official Google reCAPTCHA token</span>
    MessageBox<span class="token punctuation">.</span><span class="token function">Show</span><span class="token punctuation">(</span><span class="token interpolation-string"><span class="token string">$&quot;Token: </span><span class="token interpolation"><span class="token punctuation">{</span><span class="token expression language-csharp">Token</span><span class="token punctuation">}</span></span><span class="token string">&quot;</span></span><span class="token punctuation">,</span> <span class="token string">&quot;Verification successful!&quot;</span><span class="token punctuation">,</span> MessageBoxButton<span class="token punctuation">.</span>OK<span class="token punctuation">,</span> MessageBoxImage<span class="token punctuation">.</span>Information<span class="token punctuation">)</span><span class="token punctuation">;</span>
<span class="token punctuation">}</span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><h3 id="step-6-add-recaptcha-widget" tabindex="-1"><a class="header-anchor" href="#step-6-add-recaptcha-widget" aria-hidden="true">#</a> Step 6: Add reCAPTCHA widget</h3>`,4),S=t(`<p>After installing the necessary resources to your App you can just add the <code>&lt;ui:ReCaptcha /&gt;</code> control to your visual tree. Make sure to bind all properties and commands set in the ViewModel.</p><div class="language-xml line-numbers-mode" data-ext="xml"><pre class="language-xml"><code><span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span><span class="token namespace">ui:</span>ReCaptcha</span>
    <span class="token attr-name">HorizontalAlignment</span><span class="token attr-value"><span class="token punctuation attr-equals">=</span><span class="token punctuation">&quot;</span>Left<span class="token punctuation">&quot;</span></span>
    <span class="token attr-name">ErrorMessage</span><span class="token attr-value"><span class="token punctuation attr-equals">=</span><span class="token punctuation">&quot;</span>{Binding ErroMessage}<span class="token punctuation">&quot;</span></span>
    <span class="token attr-name">IsChecked</span><span class="token attr-value"><span class="token punctuation attr-equals">=</span><span class="token punctuation">&quot;</span>{Binding IsChecked, Mode=TwoWay}<span class="token punctuation">&quot;</span></span>
    <span class="token attr-name">IsLoading</span><span class="token attr-value"><span class="token punctuation attr-equals">=</span><span class="token punctuation">&quot;</span>{Binding IsLoading}<span class="token punctuation">&quot;</span></span>
    <span class="token attr-name">VerificationRemovedCommand</span><span class="token attr-value"><span class="token punctuation attr-equals">=</span><span class="token punctuation">&quot;</span>{Binding RemoveVerificationCommand}<span class="token punctuation">&quot;</span></span>
    <span class="token attr-name">VerificationRequestedCommand</span><span class="token attr-value"><span class="token punctuation attr-equals">=</span><span class="token punctuation">&quot;</span>{Binding VerifyCommand}<span class="token punctuation">&quot;</span></span><span class="token punctuation">&gt;</span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span><span class="token namespace">ui:</span>ReCaptcha.Theme</span><span class="token punctuation">&gt;</span></span>
        <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;</span><span class="token namespace">themes:</span>DarkTheme</span> <span class="token punctuation">/&gt;</span></span>
    <span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span><span class="token namespace">ui:</span>ReCaptcha.Theme</span><span class="token punctuation">&gt;</span></span>
<span class="token tag"><span class="token tag"><span class="token punctuation">&lt;/</span><span class="token namespace">ui:</span>ReCaptcha</span><span class="token punctuation">&gt;</span></span>
</code></pre><div class="line-numbers" aria-hidden="true"><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div><div class="line-number"></div></div></div><h2 id="final-product" tabindex="-1"><a class="header-anchor" href="#final-product" aria-hidden="true">#</a> Final Product</h2><p>If you did everything correct your application should look like this: <img src="`+d+'" alt=""></p><p>It may happen that Google requests user input for the verification. But dont worry, ReCaptcha.Desktop fully supports reCAPTCHA, even audio challanges. The ReCaptcha popup will look like this: <img src="'+k+'" alt=""></p><hr>',6),P={href:"https://github.com/IcySnex/ReCaptcha.Desktop/tree/main/Samples/SimpleExampleMVVM",target:"_blank",rel:"noopener noreferrer"};function D(E,B){const e=o("ExternalLinkIcon"),p=o("RouterLink");return i(),l("div",null,[m,s("p",null,[n("Using the ReCaptcha control in your applications is really easy and the exact same for all supported platforms ("),s("a",h,[n("WPF"),a(e)]),n(", "),s("a",g,[n("WinUI3"),a(e)]),n(", "),s("a",b,[n("UWP"),a(e)]),n("). This guide will explain how to use the ReCaptcha.Desktop with the control inside a MVVM application.")]),s("p",null,[n("For this example we use WPF with "),s("a",f,[n("Dependency Injection"),a(e)]),n(" and the "),s("a",w,[n("CommunityToolkit.MVVM"),a(e)]),n(" library but you can use whatever you prefer, just make sure you correctly set up your project for MVVM and Dependency Injection.")]),y,s("h3",C,[_,n(" Step 2: Add ReCaptcha service to your App "),s("a",x,[n("ServiceProvider"),a(e)])]),s("p",null,[n("This example project uses the "),s("a",T,[n("Microsoft.Extensions.Logging"),a(e)]),n(" logging infrastructure but you can also use any other logger like "),s("a",V,[n("Serilog"),a(e)]),n(". ReCaptcha.Desktop supports out of the box logging. Just pass in a "),M,n(" into the constructor and you are good to go.")]),R,s("p",null,[n('This is an example "user registration" form. You can view the full XAML code on '),s("a",I,[n("GitHub"),a(e)]),A]),q,s("p",null,[n("Befroe you can start using the ReCaptcha control in your user interface, you have to follow the steps on the "),a(p,{to:"/guide/widget.html#installation"},{default:u(()=>[n("Widget Installation")]),_:1}),n(" guide.")]),S,s("p",null,[n("As you can see ReCaptcha.Desktop works perfectly and looks just like the origianl Google reCAPTCHA widget. And as you noticed, it was not really hard to set up, right? The full code for this example is on "),s("a",P,[n("GitHub"),a(e)]),n(", if you're interested. Good luck, verifying!")])])}const H=c(v,[["render",D],["__file","how-to-use.html.vue"]]);export{H as default};