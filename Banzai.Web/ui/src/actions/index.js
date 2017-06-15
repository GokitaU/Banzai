export const GameStatus = {
  NOT_STARTED: 'NOT_STARTED',
  IN_PROGRESS: 'IN_PROGRESS',
  COMPLETE: 'COMPLETE'
}

export const CHANGE_STATUS = 'CHANGE_STATUS'

export function changeStatus(status) {
  return { type: CHANGE_STATUS, status }
}
