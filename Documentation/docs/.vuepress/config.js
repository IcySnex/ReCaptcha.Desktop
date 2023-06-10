import { defineUserConfig } from 'vuepress'
import { defaultTheme } from '@vuepress/theme-default'
import { searchPlugin } from '@vuepress/plugin-search'

export default defineUserConfig({
  base: '/ReCaptcha.Desktop/',
  lang: 'en-US',
  title: 'ReCaptcha.Desktop',
  description: 'Access Google reCAPTCHA on all major windows desktop frameworks (WPF, WinUI, UWP, Winforms, Console) ',

  head: [[ 'link', { rel: 'icon', href: '/ReCaptcha.Desktop/icon.svg' }]],
  theme: defaultTheme({
    colorMode: 'dark',
    logo: '/icon.svg',

    repo: 'IcySnex/ReCaptcha.Desktop',
    editLinkText: 'Edit this page on GitHub',

    docsRepo: 'IcySnex/ReCaptcha.Desktop',
    docsBranch: 'main',
    docsDir: 'Documentation/docs',

    sidebar: [
      {
        text: 'Guide',
        link: '/guide',
        collapsible: true,
        children: [
          '/guide/getting-started',
          '/guide/configurating',
          '/guide/widget',
          '/guide/how-to-use',
        ]
      },
      {
        text: 'Reference',
        link: '/reference',
        collapsible: true,
        children: [
          {
            text: 'ReCaptcha.Desktop',
            link: '/reference/recaptcha.desktop',
            collapsible: true,
            children: [
              {
                text: 'Client',
                link: '/reference/recaptcha.desktop/client',
                collapsible: true,
                children: [
                  {
                    text: 'Base',
                    link: '/reference/recaptcha.desktop/client/base',
                    collapsible: true,
                    children: [
                      '/reference/recaptcha.desktop/client/base/recaptchabase',
                      '/reference/recaptcha.desktop/client/base/recaptcharesizeablebase'
                    ]
                  },
                  {
                    text: 'Interfaces',
                    link: '/reference/recaptcha.desktop/client/interfaces',
                    collapsible: true,
                    children: [
                      '/reference/recaptcha.desktop/client/interfaces/irecaptchabase',
                      '/reference/recaptcha.desktop/client/interfaces/irecaptchaclient'
                    ]
                  }
                ]
              },
              {
                text: 'Configuration',
                link: '/reference/recaptcha.desktop/configuration',
                collapsible: true,
                children: [
                  '/reference/recaptcha.desktop/configuration/extentions',
                  '/reference/recaptcha.desktop/configuration/httpserverconfig',
                  '/reference/recaptcha.desktop/configuration/recaptchaconfig'
                ]
              },
              {
                text: 'EventArgs',
                link: '/reference/recaptcha.desktop/eventargs',
                collapsible: true,
                children: [
                  '/reference/recaptcha.desktop/eventargs/httpserverstartedeventargs',
                  '/reference/recaptcha.desktop/eventargs/httpserverstoppedeventargs',
                  '/reference/recaptcha.desktop/eventargs/recaptcharesizedeventargs',
                  '/reference/recaptcha.desktop/eventargs/requesterroroccurredeventargs',
                  '/reference/recaptcha.desktop/eventargs/requestoccurredeventargs',
                  '/reference/recaptcha.desktop/eventargs/verificationcancelledeventargs',
                  '/reference/recaptcha.desktop/eventargs/verificationrecievedeventargs'
                ]
              },
              {
                text: 'HTTP',
                link: '/reference/recaptcha.desktop/http',
                collapsible: true,
                children: [
                  {
                    text: 'Interfaces',
                    link: '/reference/recaptcha.desktop/http/interfaces',
                    collapsible: true,
                    children: [
                      '/reference/recaptcha.desktop/http/interfaces/ihttpserver',
                    ]
                  },
                  '/reference/recaptcha.desktop/http/httpserver'
                ]
              }
            ]
          },
          {
            text: 'ReCaptcha.Desktop.WPF',
            link: '/reference/recaptcha.desktop.wpf',
            collapsible: true,
            children: [
              {
                text: 'Client',
                link: '/reference/recaptcha.desktop.wpf/client',
                collapsible: true,
                children: [
                  '/reference/recaptcha.desktop.wpf/client/recaptchaclient',
                  '/reference/recaptcha.desktop.wpf/client/recaptchareciever'
                ]
              },
              {
                text: 'Configuration',
                link: '/reference/recaptcha.desktop.wpf/configuration',
                collapsible: true,
                children: [
                  '/reference/recaptcha.desktop.wpf/configuration/extentions',
                  '/reference/recaptcha.desktop.wpf/configuration/windowconfig'
                ]
              },
              {
                text: 'UI',
                link: '/reference/recaptcha.desktop.wpf/ui',
                collapsible: true,
                children: [
                  {
                    text: 'Themes',
                    link: '/reference/recaptcha.desktop.wpf/ui/themes',
                    collapsible: true,
                    children: [
                      {
                        text: 'Interfaces',
                        link: '/reference/recaptcha.desktop.wpf/ui/themes/interfaces',
                        collapsible: true,
                        children: [
                          '/reference/recaptcha.desktop.wpf/ui/themes/interfaces/itheme',
                        ]
                      },
                      '/reference/recaptcha.desktop.wpf/ui/themes/darktheme',
                      '/reference/recaptcha.desktop.wpf/ui/themes/lighttheme',
                    ]
                  },
                  '/reference/recaptcha.desktop.wpf/ui/commondictionary',
                  '/reference/recaptcha.desktop.wpf/ui/recaptcha'
                ]
              }
            ]
          },
          {
            text: 'ReCaptcha.Desktop.WinUI',
            link: '/reference/recaptcha.desktop.winui',
            collapsible: true,
            children: [
              {
                text: 'Client',
                link: '/reference/recaptcha.desktop.winui/client',
                collapsible: true,
                children: [
                  '/reference/recaptcha.desktop.winui/client/recaptchaclient',
                  '/reference/recaptcha.desktop.winui/client/recaptchareciever'
                ]
              },
              {
                text: 'Configuration',
                link: '/reference/recaptcha.desktop.winui/configuration',
                collapsible: true,
                children: [
                  '/reference/recaptcha.desktop.winui/configuration/extentions',
                  '/reference/recaptcha.desktop.winui/configuration/windowconfig',
                  '/reference/recaptcha.desktop.winui/configuration/windowstartuplocation'
                ]
              },
              {
                text: 'UI',
                link: '/reference/recaptcha.desktop.winui/ui',
                collapsible: true,
                children: [
                  {
                    text: 'Themes',
                    link: '/reference/recaptcha.desktop.winui/ui/themes',
                    collapsible: true,
                    children: [
                      {
                        text: 'Interfaces',
                        link: '/reference/recaptcha.desktop.winui/ui/themes/interfaces',
                        collapsible: true,
                        children: [
                          '/reference/recaptcha.desktop.winui/ui/themes/interfaces/itheme',
                        ]
                      },
                      '/reference/recaptcha.desktop.winui/ui/themes/darktheme',
                      '/reference/recaptcha.desktop.winui/ui/themes/lighttheme',
                    ]
                  },
                  '/reference/recaptcha.desktop.winui/ui/commondictionary',
                  '/reference/recaptcha.desktop.winui/ui/recaptcha'
                ]
              }
            ]
          },
          {
            text: 'ReCaptcha.Desktop.UWP',
            link: '/reference/recaptcha.desktop.uwp',
            collapsible: true,
            children: [
              {
                text: 'Client',
                link: '/reference/recaptcha.desktop.uwp/client',
                collapsible: true,
                children: [
                  '/reference/recaptcha.desktop.uwp/client/recaptchaclient',
                  '/reference/recaptcha.desktop.uwp/client/recaptchareciever'
                ]
              },
              {
                text: 'Configuration',
                link: '/reference/recaptcha.desktop.uwp/configuration',
                collapsible: true,
                children: [
                  '/reference/recaptcha.desktop.uwp/configuration/extentions',
                  '/reference/recaptcha.desktop.uwp/configuration/popupconfig',
                  '/reference/recaptcha.desktop.uwp/configuration/popupstartuplocation'
                ]
              },
              {
                text: 'UI',
                link: '/reference/recaptcha.desktop.uwp/ui',
                collapsible: true,
                children: [
                  {
                    text: 'Themes',
                    link: '/reference/recaptcha.desktop.uwp/ui/themes',
                    collapsible: true,
                    children: [
                      {
                        text: 'Interfaces',
                        link: '/reference/recaptcha.desktop.uwp/ui/themes/interfaces',
                        collapsible: true,
                        children: [
                          '/reference/recaptcha.desktop.uwp/ui/themes/interfaces/itheme',
                        ]
                      },
                      '/reference/recaptcha.desktop.uwp/ui/themes/darktheme',
                      '/reference/recaptcha.desktop.uwp/ui/themes/lighttheme',
                    ]
                  },
                  '/reference/recaptcha.desktop.uwp/ui/commondictionary',
                  '/reference/recaptcha.desktop.uwp/ui/recaptcha'
                ]
              }
            ]
          },
          {
            text: 'ReCaptcha.Desktop.WinForms',
            link: '/reference/recaptcha.desktop.winforms',
            collapsible: true,
            children: [
              {
                text: 'Client',
                link: '/reference/recaptcha.desktop.winforms/client',
                collapsible: true,
                children: [
                  '/reference/recaptcha.desktop.winforms/client/recaptchaclient',
                  '/reference/recaptcha.desktop.winforms/client/recaptchareciever'
                ]
              },
              {
                text: 'Configuration',
                link: '/reference/recaptcha.desktop.winforms/configuration',
                collapsible: true,
                children: [
                  '/reference/recaptcha.desktop.winforms/configuration/extentions',
                  '/reference/recaptcha.desktop.winforms/configuration/windowconfig'
                ]
              }
            ]
          },
        ]
      }
    ],
    
    navbar: [
      {
        text: 'Guide',
        link: '/guide'
      },
      {
        text: 'Reference',
        children:
        [
          {
            text: 'ReCaptcha.Desktop',
            link: '/reference/recaptcha.desktop',
            children: [
              {
                text: 'Client',
                link: '/reference/recaptcha.desktop/client',
              },
              {
                text: 'Configuration',
                link: '/reference/recaptcha.desktop/configuration',
              },
              {
                text: 'EventArgs',
                link: '/reference/recaptcha.desktop/eventargs',
              },
              {
                text: 'HTTP',
                link: '/reference/recaptcha.desktop/http',
              }
            ]
          },
          {
            text: 'ReCaptcha.Desktop.WPF',
            link: '/reference/recaptcha.desktop.wpf',
            children: [
              {
                text: 'Client',
                link: '/reference/recaptcha.desktop.wpf/client',
              },
              {
                text: 'Configuration',
                link: '/reference/recaptcha.desktop.wpf/configuration',
              },
              {
                text: 'UI',
                link: '/reference/recaptcha.desktop.wpf/ui',
              }
            ]
          },
          {
            text: 'ReCaptcha.Desktop.WinUI',
            link: '/reference/recaptcha.desktop.winui',
            children: [
              {
                text: 'Client',
                link: '/reference/recaptcha.desktop.winui/client',
              },
              {
                text: 'Configuration',
                link: '/reference/recaptcha.desktop.winui/configuration',
              },
              {
                text: 'UI',
                link: '/reference/recaptcha.desktop.winui/ui',
              }
            ]
          },
          {
            text: 'ReCaptcha.Desktop.UWP',
            link: '/reference/recaptcha.desktop.uwp',
            children: [
              {
                text: 'Client',
                link: '/reference/recaptcha.desktop.uwp/client',
              },
              {
                text: 'Configuration',
                link: '/reference/recaptcha.desktop.uwp/configuration',
              },
              {
                text: 'UI',
                link: '/reference/recaptcha.desktop.uwp/ui',
              }
            ]
          },
          {
            text: 'ReCaptcha.Desktop.WinForms',
            link: '/reference/recaptcha.desktop.winforms',
            children: [
              {
                text: 'Client',
                link: '/reference/recaptcha.desktop.winforms/client',
              },
              {
                text: 'Configuration',
                link: '/reference/recaptcha.desktop.winforms/configuration',
              }
            ]
          }
        ],
      },
    ]
  }),

  plugins: [
    searchPlugin({
      maxSuggestions: 10,
      getExtraFields: (page) => page.frontmatter.tags ?? [],
      locales: { '/': { placeholder: 'Search' }}
    })
  ]
})