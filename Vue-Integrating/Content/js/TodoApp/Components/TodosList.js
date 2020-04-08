
const { mapGetters } = Vuex;
import './TodoItem.js'

Vue.component('TodosList', {
    name: 'todos-list',
    template: `
          <div class="todos mt-5">
            <TodoItem v-for="todo in todos" :key="todo.id" :todo="todo"></TodoItem>
          </div>
    `,
    //components: {
    //    TodoItem
    //},

    computed: {
        ...mapGetters({
            todos: "todos"
        })
    }
})
