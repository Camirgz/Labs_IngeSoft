const { defineConfig } = require('@vue/cli-service')
module.exports = defineConfig({
  transpileDependencies: [],
  devServer: {
    https: false,
    port: 8080
  }
})
