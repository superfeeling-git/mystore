import Vue from 'vue'
import Router from 'vue-router'
import Login from '../page/Login'
import List from '../page/List'
import car from '../page/car'

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
    },
    {
      path: '/car',
      name: 'car',
      component: car
    }
  ]
})
