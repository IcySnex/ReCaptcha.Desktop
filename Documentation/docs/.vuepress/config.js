import { defineUserConfig } from 'vuepress'
import { defaultTheme } from '@vuepress/theme-default'
import { searchPlugin } from '@vuepress/plugin-search'

export default defineUserConfig({
  base: '/ReCaptcha.Desktop/',
  lang: 'en-US',
  title: 'ReCaptcha.Desktop',
  description: 'Access Google reCAPTCHA on all major windows desktop frameworks (WPF, WinUI, UWP, Winforms, Console) ',

  head: [[ 'link', { rel: 'icon', href: '/icon.svg' }]],
  theme: defaultTheme({
    colorMode: 'dark',
    logo: '/icon.svg',

    repo: 'IcySnex/ReCaptcha.Desktop',
    editLinkText: 'Edit this page on GitHub',

    docsRepo: 'IcySnex/ReCaptcha.Desktop',
    docsBranch: 'docs',
    docsDir: 'docs',

    sidebar: {
      '/guide': [
        {
          text: 'Guide',
          children: [ '/guide', '/guide/getting-started' ],
        }
      ]
    },

    navbar: [{ text: 'Guide', link: '/guide/getting-started' }]
  }),

  plugins: [
    searchPlugin({
      maxSuggestions: 10,
      locales: { '/': { placeholder: 'Search' }}
    })
  ]
})