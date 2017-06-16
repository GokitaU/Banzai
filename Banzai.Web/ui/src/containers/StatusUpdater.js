import React from 'react'
import { connect } from 'react-redux'
import { changeStatus, GameStatus } from '../actions'

let StatusUpdater = ({ dispatch }) => {
  return (
    <div>
      <form onSubmit={e => { e.preventDefault(); dispatch(changeStatus(document.getElementById('GameStatusDropDown').value)) }}>
        <select id="GameStatusDropDown">
          <option value={GameStatus.NOT_STARTED}>Not Started</option>
          <option value={GameStatus.IN_PROGRESS}>In Progress</option>
          <option value={GameStatus.COMPLETE}>Complete</option>
        </select>

        <button type="submit">
          Update Game Status
        </button>
      </form>
    </div>
  )
}
StatusUpdater = connect()(StatusUpdater)

export default StatusUpdater
