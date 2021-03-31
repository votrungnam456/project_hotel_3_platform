import Home from "./components/home/Index";
import Introduction from './components/introductions/Introductions'
import Contact from './components/contact/Contact'
import NotFound from './components/error/NotFound'
import Gallery from './components/gallery/Gallery'
import ListRoom from './components/rooms/ListRoom'
const routes = [
     {
          path: '/',
          exact: true,
          main: () => <Home></Home>
     },
     {
          path: '/intro',
          exact: false,
          main: () => <Introduction></Introduction>
     },
     {
          path: '/contact',
          exact: false,
          main: () => <Contact></Contact>
     },
     {
          path: '/gallery',
          exact: false,
          main: () => <Gallery></Gallery>
     },
     {
          path: '/rooms',
          exact: true,
          main: ({match}) => <ListRoom match={match}></ListRoom>
     },
     {
          path: '',
          exact: false,
          main: () => <NotFound></NotFound>
     }
]

export default routes