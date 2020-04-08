//import { v4 as uuidv4 } from "uuid";

export default new Vuex.Store({
    state: {
        filter: "all",
        allTodos: [
            {
                id: uuidv4(),
                title: "Research Vue.Js"
            },
            {
                id: uuidv4(),
                title: "Finish PDRS V1.1",
                completed: true
            },
            {
                id: uuidv4(),
                title: "Reach the end of OneShot"
            }
        ]
    },
    getters: {
        remaining: state => state.allTodos.filter(t => !t.completed).length,
        todos: state => {
            if (state.filter === "all") return state.allTodos;
            if (state.filter === "completed")
                return state.allTodos.filter(t => t.completed);
            if (state.filter === "active")
                return state.allTodos.filter(t => !t.completed);
        }
    },
    mutations: {
        toggleTodo(state, { id }) {
            state.allTodos = state.allTodos.map(t => {
                if (t.id === id) t.completed = !t.completed;
                return t;
            });
        },
        addTodo(state, { title }) {
            state.allTodos.unshift({ id: uuidv4(), title, completed: false });
        },
        filter(state, { filter }) {
            state.filter = filter;
        },
        addTodos(state, { todos }) {
            state.allTodos = [...todos, ...state.allTodos];
        }
    },
    actions: {
        async fetchTodos({ commit, state }) {
            const res = await fetch(
                "http://jsonplaceholder.typicode.com/todos?_limit=3"
            );
            const data = await res.json();
            const todosToAdd = data.map(t => ({
                id: uuidv4(),
                title: t.title,
                completed: t.completed
            }));
            commit("addTodos", { todos: todosToAdd });
        }
    }
});
