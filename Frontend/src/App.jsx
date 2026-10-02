import './App.css'
import { Route, Routes } from 'react-router-dom'
import Home from './Pages/Home.jsx'
import Error from './Pages/Error.jsx'

function App() {
  return (
    <Routes>
      <Route path="/" element={<Home />} />
      <Route path="*" element={<Error />} />
    </Routes>
  )
}

export default App