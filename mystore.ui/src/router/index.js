import Vue from 'vue'
import Router from 'vue-router'
import Login from '../page/Login'
import List from '../page/List'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Login',
      component: Login
    },
    {
      path: '/List',
      name: 'List',
      component: List
    }
  ]
})
