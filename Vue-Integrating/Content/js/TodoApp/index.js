import store from './store.js'
import router from './router.js'




new Vue({
    el: "#todo-app",
    data: {
        message: "hello from Vue"
    },
    store,
    router
});
