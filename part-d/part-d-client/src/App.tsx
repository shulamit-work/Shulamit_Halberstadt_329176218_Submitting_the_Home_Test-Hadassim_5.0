import { useState } from 'react'
import { Route } from 'react-router-dom'
import './App.css'
import { Router, Routes } from 'react-router-dom'
import LoginPage from './pages/LoginPage'
function App() {
    return(
      <Router>
          <Routes>
              <Route path="/" element={<LoginPage />} />
              
          </Routes>
      </Router>

    )


  
    
}

export default App
