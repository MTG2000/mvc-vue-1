import About from './Views/AboutTodo.vue.js'
import MainTodo from './Views/MainTodo.js'

const routes = [
    {
        path: '/about',
        component: About
    },
    {
        path: '/',
        component: MainTodo
    }
]

export default new VueRouter({
    routes: routes,
    base: '/todos',
    mode:'history'
})