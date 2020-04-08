import '../Components/TodosList.js'
import '../Components/AddTodo.js'
import '../Components/TodoHelpers.js'


export default Vue.component("MainTodo", {
    template: `  
        <div>
            <add-todo></add-todo>
            <todos-list></todos-list>
            <todo-helpers></todo-helpers>
        </div>
    `,
})