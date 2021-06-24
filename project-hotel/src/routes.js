import Home from "./components/home/Index";
import Introduction from './components/introductions/Introductions'
import Contact from './components/contact/Contact'
import NotFound from './components/error/NotFound'
import Gallery from './components/gallery/Gallery'
import ListRoom from './components/rooms/ListRoom'
import RoomDetail from './components/rooms/RoomDetails'
import Login from "./components/login/login";
import Register from './components/login/register'
import Logout from './components/login/logout'
import BookingRoom from "./components/rooms/BookingRoom";
import InfomationCustomer from "./components/customer/InfomationCustomer";
const routes = [
     {
          path: '/',
          exact: true,
          main: () => <Home></Home>
     },
     {
          path: '/intro',
          exact: false,
          main: ({history}) => <Introduction history={history}></Introduction>
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
          path: '/bookingComplete',
          exact: true,
          main: ({history}) => <BookingRoom history={history}></BookingRoom>
     },
     {
          path: '/register',
          exact: true,
          main: ({history}) => <Register history={history}></Register>
     },
     {
          path: '/infoCustomer',
          exact: true,
          main: ({history}) => <InfomationCustomer history={history}></InfomationCustomer>
     },
     {
          path: '/rooms',
          exact: true,
          main: ({history,match}) => <ListRoom history={history} match={match}></ListRoom>
     },
     {
          path: '/rooms/:id',
          exact: true,
          main: ({match,history}) => <RoomDetail history={history} match={match}></RoomDetail>
     },
     {
          path: '',
          exact: false,
          main: () => <NotFound></NotFound>
     }
]

export default routes