const { mapMutations } = Vuex;

Vue.component('TodoItem', {
    template: `
  <div class="todo-item px-5 py-4">
    <input type="checkbox" :checked="todo.completed" @change="toggleTodo({id:todo.id})" />
    <span class="mx-2">{{todo.title}}</span>
  </div>
    `,
    props: {
        todo: {
            type: Object,
            required: true
        }
    },
    methods: {
        ...mapMutations({
            toggleTodo: "toggleTodo"
        })
    }
})