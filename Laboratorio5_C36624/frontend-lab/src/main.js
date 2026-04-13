import { createApp } from 'vue'
import App from './App.vue'
import { createRouter, createWebHistory } from 'vue-router'
import CountriesList from './components/CountriesList.vue'

const router = createRouter({
  history: createWebHistory(),
  routes: [
    { path: '/', name: 'Home', component: CountriesList },
  ],
});

createApp(App).use(router).mount('#app')
